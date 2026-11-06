using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using poliklinikaApi.Models;
using System;
using System.Threading.Tasks;

namespace poliklinikaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly User84DbContext _context;

        public AppointmentsController(User84DbContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateAppointment([FromBody] AppointmentRequest request)
        {
            var patient = await _context.KpPacienties.FindAsync(request.PatientId);
            var slot = await _context.KpRaspisanies.FindAsync(request.ScheduleId);

            if (patient == null || slot == null)
            {
                return BadRequest(new { error = "Пациент или слот расписания не найдены" });
            }

            var existingAppointment = await _context.KpZapisiNaPriems
                .FirstOrDefaultAsync(z => z.KodSlota == request.ScheduleId);

            if (existingAppointment != null)
            {
                return Conflict(new { error = "Данное время уже занято другим пациентом", code = "SLOT_ALREADY_BOOKED" });
            }

            // ВАЖНО: StatusZapisi = 1 (если у тебя int). Если строка, замени на "Zaplanirovana"
            var newAppointment = new KpZapisiNaPriem
            {
                KodPacienta = request.PatientId,
                KodSlota = request.ScheduleId,
                DataSozdaniya = DateTime.Now,
                StatusZapisi = 1
            };

            _context.KpZapisiNaPriems.Add(newAppointment);
            slot.Status = 2; // Если Status int, замени на 2

            await _context.SaveChangesAsync();

            // Привязываем услугу (если передана)
            if (request.ServiceId.HasValue && request.ServiceId.Value > 0)
            {
                var serviceLink = new KpUslugiZapisi
                {
                    KodZapisi = newAppointment.KodZapisi,
                    KodUslugi = request.ServiceId.Value
                };
                _context.KpUslugiZapisis.Add(serviceLink);
                await _context.SaveChangesAsync();
            }

            return CreatedAtAction(nameof(CreateAppointment), new { id = newAppointment.KodZapisi }, new
            {
                message = "Запись успешно создана",
                appointmentId = newAppointment.KodZapisi
            });
        }
    }

    public class AppointmentRequest
    {
        public int PatientId { get; set; }
        public int ScheduleId { get; set; }
        public int? ServiceId { get; set; }
    }
}
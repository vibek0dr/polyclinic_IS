using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using poliklinikaApi.Models;

namespace poliklinikaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DoctorsController : ControllerBase
    {
        private readonly User84DbContext _context;

        public DoctorsController(User84DbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetDoctors()
        {
            var doctors = await _context.KpVrachis
                .Include(d => d.KodSpecializaciiNavigation)
                .Select(d => new
                {
                    d.KodVracha,
                    Fio = d.Familiya + " " + d.Imya + " " + d.Otchestvo,
                    Specialization = d.KodSpecializaciiNavigation.NazvanieSpecializacii,
                    d.NomerKabineta
                })
                .ToListAsync();

            return Ok(doctors);
        }
    }
}
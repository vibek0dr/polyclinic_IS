using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using poliklinikaApi.Models;

namespace poliklinikaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ServicesController : ControllerBase
    {
        private readonly User84DbContext _context;

        public ServicesController(User84DbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetServices()
        {
            var services = await _context.KpUslugis
                .Select(s => new
                {
                    s.KodUslugi,
                    s.Nazvanie,
                    s.Stoimost,
                    s.Image
                })
                .ToListAsync();

            return Ok(services);
        }
    }
}
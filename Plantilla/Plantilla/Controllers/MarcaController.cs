using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plantilla.Models;

namespace Plantilla.Controllers
{
    public class MarcaController : Controller
    {
        private readonly plantillaContext _context;

        public MarcaController(plantillaContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
            
            => View(await _context.Marcas.ToListAsync());
       
    }
}

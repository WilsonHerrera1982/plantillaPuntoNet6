using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plantilla.Models;

namespace Plantilla.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiProductosController : ControllerBase
    {
        private readonly plantillaContext _context;

        public ApiProductosController(plantillaContext context)
        {
            _context = context;
        }

        public async Task<List<Producto>> Get()
       => await _context.Productos.ToListAsync();

    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Plantilla.Models;
using Plantilla.Models.ViewModel;

namespace Plantilla.Controllers
{
    public class ProductoController : Controller
    {
        private readonly plantillaContext _context;

        public ProductoController(plantillaContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var productos = _context.Productos.Include(m => m.Marca);
            return View( await productos.ToListAsync());
        }

        public IActionResult Create()
        {
            ViewData["Marcas"] = new SelectList(_context.Marcas,"Id","Nombre");
                return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductoViewModel pro)
        {
            if (ModelState.IsValid)
            {
                var producto = new Producto()
                {
                    Nombre = pro.Nombre,
                    Estado = true,
                    IdMarca = pro.IdMarca,
                };
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Marcas"] = new SelectList(_context.Marcas, "Id", "Nombre", pro.IdMarca);
            return View(pro);
        }


    }
}

using System.ComponentModel.DataAnnotations;

namespace Plantilla.Models.ViewModel
{
    public class ProductoViewModel
    {
        [Required]
        [Display (Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        public int IdMarca { get; set; }
    }
}

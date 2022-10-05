using System;
using System.Collections.Generic;

namespace Plantilla.Models
{
    public partial class Producto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
        public int? IdMarca { get; set; }

        public virtual Marca? Marca { get; set; }
    }
}

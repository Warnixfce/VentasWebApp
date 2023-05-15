using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentasWebApp.Models
{
    public class productos
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public float? Precio { get; set; }

        public string Categoria { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentasWebApp.Models
{
    public class ventas
    {
        public int Id { get; set; }

        public int IdCliente { get; set; }

        public DateTime? Fecha { get; set; }

        public float? Total { get; set; }
    }
}
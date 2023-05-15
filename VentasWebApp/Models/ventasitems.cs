using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentasWebApp.Models
{
    public class ventasitems
    {
        public int Id { get; set; }

        public int IdVenta { get; set; }

        public int IdProducto { get; set; }

        public float? PrecioUnitario { get; set; }

        public float? Cantidad { get; set; }

        public float? PrecioTotal { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1.Entidades
{
    public class Sale
    {
        public int idProducto { get; set; }
        public String nombreProducto { get; set; }
        public String descripcionProducto { get; set; }

        public float precioProducto { get; set; }
        public int cantidadProducto { get; set; }

        public float totalProducto { get; set; }
        public float descuento { get; set; }
    }
}

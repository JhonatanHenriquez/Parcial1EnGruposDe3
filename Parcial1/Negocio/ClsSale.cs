using Parcial1.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1.Negocio
{
    public class ClsSale
    {
        public void Charge(Sale data)
        {
            data.totalProducto = data.precioProducto * data.cantidadProducto;
            data.descuento = 0;
            Console.WriteLine("\nEfectuando compra");
            Console.WriteLine($"ID Producto '{data.idProducto}'");
            Console.WriteLine($"Nombre Producto '{data.nombreProducto}'");
            Console.WriteLine($"Descripcion Producto '{data.descripcionProducto}'");
            Console.WriteLine($"Precio Producto '{data.precioProducto}'");
            Console.WriteLine($"Cantidad Producto '{data.cantidadProducto}'");
            if (data.totalProducto > 50)
            {
                data.descuento = 10;
                Console.WriteLine($"Descuento Producto '{data.descuento}'");
                data.totalProducto = data.totalProducto - data.descuento;
                data.descuento = 0;
            }
            else {
                
                Console.WriteLine($"Descuento Producto '{data.descuento}'");
            }
            Console.WriteLine($"Total a pagar '{data.totalProducto}'");



        }
    }
}

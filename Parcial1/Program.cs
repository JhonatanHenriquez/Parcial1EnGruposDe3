using System;
using Parcial1.Entidades;
using Parcial1.Negocio;
namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            ClsUser clsUser = new ClsUser();
            Sale sale = new Sale();
            ClsSale clsSale = new ClsSale();
            Boolean execute = false;


            Console.WriteLine("Ingrese su usuario");
            user.user = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña");
            user.pass = Console.ReadLine();
            Console.WriteLine("\n");
            if (clsUser.singIn(user) == 1) {
                do
                {
                    Console.WriteLine("\nIngrese ID del producto");
                    sale.idProducto = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese nombre del producto");
                    sale.nombreProducto = Console.ReadLine();
                    Console.WriteLine("Ingrese descripcion del producto");
                    sale.descripcionProducto = Console.ReadLine();
                    Console.WriteLine("Ingrese precio del producto");
                    sale.precioProducto = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese cantidad del producto");
                    sale.cantidadProducto = int.Parse(Console.ReadLine());
                    clsSale.Charge(sale);

                    Console.WriteLine("¿Desea volver a ejecutar? SI = S/ NO = N");
                    if (Console.ReadLine() == "S")
                    {
                        execute = true;
                    }
                    else
                    {
                        execute = false;
                    }
                } while (execute);
            };







        }
    }
}

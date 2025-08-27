using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda_online
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //si se elige cliente
            Console.Clear();
            Console.WriteLine("1. Ver productos disponibles");
            Console.WriteLine("2. Agregar producto al carrito");
            Console.WriteLine("3. Ver carrito");
            Console.WriteLine("4. Confirmar compra");
            Console.WriteLine("5. Volver al menu principal");

            Console.Write("Ingrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Mostrando productos disponibles...");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Agregando producto al carrito...");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Mostrando el carrito...");
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Confirmando la compra...");
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Volviendo al menú principal...");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }
}

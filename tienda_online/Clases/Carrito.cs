using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Carrito
    {
        public List<Producto> Productos { get; set; }

        public Carrito()
        {
            Productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto, int cantidad)
        {
            if (producto.Stock >= cantidad)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    this.Productos.Add(producto);
                }
                producto.Stock -= cantidad; // con esto reduzco el stock
            }
            else
            {
                Console.WriteLine("Stock insuficiente");
            }
        }
        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var producto in Productos)
            {
                total += producto.Precio;
            }
            return total;
        }
    }
}

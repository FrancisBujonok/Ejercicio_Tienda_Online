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
            // Lógica para agregar al carrito
        }
    }
}

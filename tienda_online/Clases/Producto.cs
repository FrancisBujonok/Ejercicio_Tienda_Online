using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Producto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }

        public Producto (int id, string nombre, int precio, int stock) 
        {
            this.ID = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Stock = stock;
        }
    }
}

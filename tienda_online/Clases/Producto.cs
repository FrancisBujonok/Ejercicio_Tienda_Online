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
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public Producto (int id, string nombre, decimal precio, int stock) 
        {
            this.ID = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Stock = stock;
        }
        public void MostrarInfo()
        {
            Console.WriteLine($"ID: {ID} | {Nombre} - ${Precio} | Stock: {Stock}");
        }
    }
}

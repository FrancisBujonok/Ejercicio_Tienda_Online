using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente : Usuario
    {
        public Carrito Carrito { get; set; }
        public Cliente(string nombre, int id) : base(nombre, id, "Cliente")
        {
            Carrito = new Carrito();
        }
        public override void MostrarInfo()
        {
            Console.WriteLine($"CLIENTE: {Nombre} (ID: {Id})");
        }
    }
}

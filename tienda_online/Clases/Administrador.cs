using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Administrador : Usuario
    {
        public Administrador(string nombre, int id) : base(nombre, id, "Administrador")
        {
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"ADMIN: {Nombre} (ID: {Id})");
        }
    }
}

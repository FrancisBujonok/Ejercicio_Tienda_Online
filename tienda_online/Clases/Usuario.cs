using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public int Id { get; set; }
        public string Tipo {  get; set; } //cliente o administrador
        public Usuario (string nombre, int id, string tipo) 
        { 
            this.Nombre = nombre;
            this.Id = id;
            this.Tipo = tipo;
        }
        public virtual void MostrarInfo() // virtual permite override
        {
            Console.WriteLine($"ID: {Id} | {Nombre} - Tipo: {Tipo}");
        }
    }
}

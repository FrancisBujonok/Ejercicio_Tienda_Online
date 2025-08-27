using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Tienda
    { 
        public List<Producto> ProductosDisponibles { get; set; }
        public List<Usuario> UsuariosRegistrados { get; set; }
        public Tienda()
        {
            ProductosDisponibles = new List<Producto>();
            UsuariosRegistrados = new List<Usuario>();
        }
        public void AgregarProducto(Producto producto)
        {
            ProductosDisponibles.Add(producto);
        }
        public void RegistrarUsuario(Usuario usuario)
        {
            UsuariosRegistrados.Add(usuario);
        }
    }
}

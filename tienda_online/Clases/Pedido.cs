using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Pedido
    {
        //la clase será de pedido/factura
        public int NumeroPedido { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public List<Producto> Productos { get; set; }
        public string DireccionEnvio { get; set; }
        public string Estado { get; set; } // "pendiente", "enviado", "entregado"
    }
}

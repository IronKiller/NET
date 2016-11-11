using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pubs2.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public int NumeroPedido { get; set; }
        public DateTime Fecha { get; set; }
        public Proveedor Proveedor { get; set; }
        public int MyProperty { get; set; }
        public int Cantidad { get; set; }
        public float PrecioTotal { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantApp
{
    class PedidoMenu
    {
        public int mesaId { get; set; }
        public string hora_pedido { get; set; }
        public Pedido[] PedidoMenuAlimentos { get; set; }

    }
}

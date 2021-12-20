using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantApp
{

    public class PedidoMenu
    {
        public int Id { get; set; }
        public int MesaId { get; set; }
        public DateTime Hora_Pedido { get; set; }
        public Pedidomenualimento[] PedidoMenuAlimentos { get; set; }
    }

    public class Pedidomenualimento
    {
            
        public int AlimentoId { get; set; }
        public int MenuId { get; set; }
    }

}

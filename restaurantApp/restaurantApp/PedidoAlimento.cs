using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantApp
{
    public class PedidoAlimento
    {
        public int Id { get; set; }
        public int MesaId { get; set; }
        public DateTime Hora_Pedido { get; set; }
        public Pedidoalimento[] PedidoAlimentos { get; set; }
    }
    public class Pedidoalimento { 
        public int AlimentoId { get; set; }
        public int Cantidad { get; set; }   
    }
}

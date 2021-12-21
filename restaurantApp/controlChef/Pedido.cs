using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlChef
{

    public class Pedido
    {
        public string id { get; set; }
        public Pedidoalimento[] PedidoAlimentos { get; set; }
        public Pedidomenualimento[] PedidoMenuAlimentos { get; set; }
        public int Id { get; set; }
        public int MesaId { get; set; }
        public object Mesa { get; set; }
        public DateTime Hora_Pedido { get; set; }
    }

    public class Pedidomenualimento
    {
        public string id { get; set; }
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public int MenuId { get; set; }
        public int AlimentoId { get; set; }
        public object Alimento { get; set; }
        public object Menu { get; set; }
    }
    public class Pedidoalimento
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public int AlimentoId { get; set; }
        public int cantidad { get; set; }
    }
    

}

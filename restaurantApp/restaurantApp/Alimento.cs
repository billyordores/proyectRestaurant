using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantApp
{
    class Alimento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoServicio { get; set; }
        public string TipoPlatillo { get; set; }
        public int TipoPlatilloId { get; set; }
        public int TipoServicioId { get; set; }
        public double Precio { get; set; }
        //int cantidad;

        public Alimento() {
        }
        
    }
}

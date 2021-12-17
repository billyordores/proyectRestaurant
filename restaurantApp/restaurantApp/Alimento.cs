using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantApp
{
    class Alimento
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string tipo_servicio { get; set; }
        public string tipo_platillo { get; set; }
        public double precio { get; set; }
        //int cantidad;

        public Alimento() {
        }
        
    }
}

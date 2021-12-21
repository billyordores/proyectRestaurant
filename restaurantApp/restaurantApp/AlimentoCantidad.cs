using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantApp
{
    public class AlimentoCantidad
    {
        public int idAlimento;
        public int cantidad { get; set; }

        public AlimentoCantidad( int alimento, int cantidad) { 
            this.idAlimento= alimento;
            this.cantidad = cantidad;   
        }
         public int GetIdAlimento() {
            return idAlimento;
         }

    }
}

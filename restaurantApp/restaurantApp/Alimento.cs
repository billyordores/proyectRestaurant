using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantApp
{
    class Alimento
    {
        int id;
        string nombre;
        string tipo_alimento;
        double precio;
        //int cantidad;

        public Alimento(string nombre, double precio) {
            this.nombre = nombre;
            this.precio = precio;
        }
        public double getPrecio() {
            return precio;
        }        
        public string getTipo_alimento() {
            return tipo_alimento;
        }
        public void setTipo_alimento(string tipo_alimento) {
            this.tipo_alimento = tipo_alimento;
        }
        public string getNombre() {
            return nombre;
        }
        public int getId() {
            return id;        
        }
       /** public void setCantidad(int cantidad) {
            this.cantidad = cantidad;
        }
        public int getCantidad() {
            return cantidad;
        }
        **/
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using restaurantApp;
using System.Collections;

namespace restaurantApp
{
    class controlMenu
    {
        public static void callItemsMenu() {
            using (System.IO.StreamReader archivo = File.OpenText(@"C:/Users/becario/Documents/git/proyectRestaurant/restaurantApp/restaurantApp/dataAlimentos.json"))

            {
                // Leemos los datos del archivo 'postre.json' desde el inicio hasta el final 
                string json = archivo.ReadToEnd();

                // Deserializamos el archivo 'postres.json'
                List<Alimento> list = new List<Alimento>();
                dynamic miarray = JsonConvert.DeserializeObject(json);

                // Recorremos el array de datos del JSON 
                foreach (var item in miarray)
                {
                    // Agregamos el campo nombre del archivo 'postres.json' al ComboBox 
                    //comboBox1.Items.Add(item.nombre);
                    list.Add(new Alimento(){ });                

                }

            }

        }


    }
}

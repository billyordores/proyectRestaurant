using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace restaurantApp
{
    class controlMenu
    {
        public static List<Alimento> GetAlimentos() {

            var url = $"https://localhost:44380/api/Alimentos";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string json = objReader.ReadToEnd();
                            JArray a = JArray.Parse(json);
                            List<Alimento> list = new List<Alimento>();
                            foreach (var item in a)
                            {
                                list.Add(new Alimento() { nombre = $"{item.SelectToken("Nombre")}", precio = Convert.ToDouble(item.SelectToken("Precio")), id =Convert.ToInt32(item.SelectToken("Id")) , tipo_platillo = $"{item.SelectToken("TipoPlatillo")}", tipo_servicio = $"{item.SelectToken("TipoServicio")}", tipo_servicio_id =Convert.ToInt32(item.SelectToken("TipoServicioId")), tipo_platillo_id = Convert.ToInt32(item.SelectToken("TipoPlatilloId")) });
                                
                            }
                            return list;
                        }
                    }
                }

            }
            catch (WebException ex)
            {
                Console.Write("Error GetAlimentos");
            }
            return null;   
        }

        public static void PostMenu(int mesaId, string alimento1, string alimento2, string alimento3, string alimento4, string hora_pedido, int menuId) {

            var url = $"https://localhost:44380/api/Pedidos";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            var jsonStringName = new JavaScriptSerializer();
            Pedido pedido1 = new Pedido() { alimentoId = getAlimentoId(alimento1) , menuId = 1};
            Pedido pedido2 = new Pedido() { alimentoId = getAlimentoId(alimento2), menuId = 1 };
            Pedido pedido3 = new Pedido() { alimentoId = getAlimentoId(alimento3), menuId = 1};
            Pedido pedido4 = new Pedido() { alimentoId = getAlimentoId(alimento4), menuId = 1};
            Pedido[] array = new Pedido[] { pedido1, pedido2, pedido3, pedido4 };
            
            var ObjectName = new PedidoMenu(){mesaId=mesaId, hora_pedido=hora_pedido, PedidoMenuAlimentos = array};
            var jsonStringResult = jsonStringName.Serialize(ObjectName);
            
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(Convert.ToString(jsonStringResult));
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                
            }
        }
        public static int getAlimentoId(String name) {

            foreach (Alimento ali in GetAlimentos()) {
                if (ali.nombre == name) {
                    return ali.id;
                }            
            }
            return -1;
        }
    }
}

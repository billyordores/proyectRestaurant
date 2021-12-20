using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Net.Http.Formatting;
using System.Security.Policy;
using Newtonsoft.Json.Linq;

namespace restaurantApp
{
    class controlMenu
    {

        public static async Task<string> Post(int mesaId, string alimento1, string alimento2, string alimento3, string alimento4, DateTime hora_pedido, int menuId) {
            string url = "https://localhost:44380/api/pedidos";
            
            var client = new HttpClient();
            Pedidomenualimento pedido1 = new Pedidomenualimento() {MenuId = 1 , AlimentoId = getAlimentoId(alimento1) };
            Pedidomenualimento pedido2 = new Pedidomenualimento() {MenuId = 1, AlimentoId = getAlimentoId(alimento2) };
            Pedidomenualimento pedido3 = new Pedidomenualimento() { MenuId = 1 , AlimentoId = getAlimentoId(alimento3)};
            Pedidomenualimento pedido4 = new Pedidomenualimento() { MenuId = 1, AlimentoId = getAlimentoId(alimento4)};
            Pedidomenualimento[] array = new Pedidomenualimento[] { pedido1, pedido2, pedido3, pedido4 };
            var ObjectName = new PedidoMenu() { MesaId = mesaId, Hora_Pedido = hora_pedido, PedidoMenuAlimentos = array };
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.PostAsJsonAsync(url, ObjectName);
                if (response.IsSuccessStatusCode)
                {
                    var id = await response.Content.ReadAsStringAsync();
                    return JsonConvert.SerializeObject(ObjectName);
                }

            }      
                        
            return JsonConvert.SerializeObject(ObjectName);

        }
        
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
                                list.Add(new Alimento() { Nombre = $"{item.SelectToken("Nombre")}", Precio = Convert.ToDouble(item.SelectToken("Precio")), Id =Convert.ToInt32(item.SelectToken("Id")) , TipoPlatillo = $"{item.SelectToken("TipoPlatillo")}", TipoServicio = $"{item.SelectToken("TipoServicio")}", TipoServicioId =Convert.ToInt32(item.SelectToken("TipoServicioId")), TipoPlatilloId = Convert.ToInt32(item.SelectToken("TipoPlatilloId")) });
                                
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

        public static void PostMenu(int mesaId, string alimento1, string alimento2, string alimento3, string alimento4, DateTime hora_pedido, int menuId) {

            string url = $"https://localhost:44380/api/Pedidos";
            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json;charset-UTF-8";
            Pedidomenualimento pedido1 = new Pedidomenualimento() { AlimentoId = getAlimentoId(alimento1) , MenuId = 1};
            Pedidomenualimento pedido2 = new Pedidomenualimento() { AlimentoId = getAlimentoId(alimento2), MenuId = 1 };
            Pedidomenualimento pedido3 = new Pedidomenualimento() { AlimentoId = getAlimentoId(alimento3), MenuId = 1};
            Pedidomenualimento pedido4 = new Pedidomenualimento() { AlimentoId = getAlimentoId(alimento4), MenuId = 1};
            Pedidomenualimento[] array = new Pedidomenualimento[] { pedido1, pedido2, pedido3, pedido4 };
            
            PedidoMenu ObjectName = new PedidoMenu(){MesaId=mesaId, Hora_Pedido=hora_pedido, PedidoMenuAlimentos = array};
            
            
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string jsonStringResult = JsonConvert.SerializeObject(ObjectName);
                streamWriter.Write(jsonStringResult);
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
                if (ali.Nombre == name) {
                    return ali.Id;
                }            
            }
            return -1;
        }
    }
}

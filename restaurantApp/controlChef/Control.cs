using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace controlChef
{
    public class Control
    {
        public static List<Pedido> GetAlimentos()
        {

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
                            List<Pedido> list = new List<Pedido>();
                            foreach (var item in a)
                            {
                                //list.Add(new Pedido() { Nombre = $"{item.SelectToken("Nombre")}", Precio = Convert.ToDouble(item.SelectToken("Precio")), Id = Convert.ToInt32(item.SelectToken("Id")), TipoPlatillo = $"{item.SelectToken("TipoPlatillo")}", TipoServicio = $"{item.SelectToken("TipoServicio")}", TipoServicioId = Convert.ToInt32(item.SelectToken("TipoServicioId")), TipoPlatilloId = Convert.ToInt32(item.SelectToken("TipoPlatilloId")) });

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
    }
}

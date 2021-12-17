using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurantApp
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxEntrantes_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            Console.WriteLine( groupMenuSegundo.Text);
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxEM_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamReader archivo = File.OpenText(@"C:/Users/becario/Documents/git/proyectRestaurant/restaurantApp/restaurantApp/dataAlimentos.json"))

            {
                // Leemos los datos del archivo 'postre.json' desde el inicio hasta el final 
                string json = archivo.ReadToEnd();

                // Deserializamos el archivo 'postres.json'
                List<Alimento> list = new List<Alimento>();
                Alimento[] alimentos = new Alimento[10];
                dynamic miarray = JsonConvert.DeserializeObject(json);
                JArray a = JArray.Parse(json);
                string name="";
                int i = 1;
                // Recorremos el array de datos del JSON 
                foreach (var item in a)
                {
                    list.Add(new Alimento() {nombre = $"{item.SelectToken("nombre")}", precio=Convert.ToDouble(item.SelectToken("precio")), id= i, tipo_platillo= $"{item.SelectToken("tipo_platillo")}", tipo_servicio= $"{item.SelectToken("tipo_servicio")}" });
                    i++;
                }
                foreach (Alimento value in list)
                {
                    name += "(" + value.nombre + " - " + value.precio + ") ";
                }

                labelControlMenu.Text =name;

            }



        }
    }
}

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
        decimal idMesa { get; set; }
        public menu(decimal idMesa)
        {
            this.idMesa = idMesa;
            InitializeComponent();
            addEntrante();
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
            Console.WriteLine( groupBoxPF.Text);
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

        private async Task button1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void addEntrante() {
            
                int e=0, pf = 0, p=0, b=0;
                int pointE=21, pointPF = 21, pointP=21, pointB=21;
                int tabIndexE=0,tabIndexPF = 0, tabIndexP=0, tabIndexB=0;

                foreach (Alimento value in controlMenuCarta.GetAlimentos())
                {
                    if (value.TipoPlatilloId ==1) {
                        RadioButton rdo = new RadioButton();
                        rdo.AutoSize = true;
                        rdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        rdo.Location = new System.Drawing.Point(21, pointE);
                        rdo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        rdo.Name = "RadioButtonEntrante" + e;
                        rdo.Size = new System.Drawing.Size(218, 29);
                        rdo.TabIndex = tabIndexE;
                        rdo.TabStop = true;
                        rdo.Text = value.Nombre;
                        rdo.UseVisualStyleBackColor = true;

                        this.groupBoxEM.Controls.Add(rdo);
                        e++;
                        tabIndexE += 1;
                        pointE += 50;

                    }
                    if (value.TipoPlatilloId==2) {
                         RadioButton rdo = new RadioButton();
                         rdo.AutoSize = true;
                         rdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                         rdo.Location = new System.Drawing.Point(21, pointPF);
                         rdo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                         rdo.Name = "RadioButtonEntrante" + pf;
                         rdo.Size = new System.Drawing.Size(218, 29);
                         rdo.TabIndex = tabIndexPF;
                         rdo.TabStop = true;
                         rdo.Text = value.Nombre;
                         rdo.UseVisualStyleBackColor = true;
                         this.groupBoxPF.Controls.Add(rdo);
                         pf++;
                         tabIndexPF += 1;
                         pointPF += 50;
                    }
                    if (value.TipoPlatilloId == 4)
                    {
                        RadioButton rdo = new RadioButton();
                        rdo.AutoSize = true;
                        rdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        rdo.Location = new System.Drawing.Point(21, pointP);
                        rdo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        rdo.Name = "RadioButtonEntrante" + p;
                        rdo.Size = new System.Drawing.Size(218, 29);
                        rdo.TabIndex = tabIndexPF;
                        rdo.TabStop = true;
                        rdo.Text = value.Nombre;
                        rdo.UseVisualStyleBackColor = true;
                        this.groupBoxP.Controls.Add(rdo);
                        p++;
                        tabIndexP += 1;
                        pointP += 50;
                    }
                    if (value.TipoPlatilloId == 6)
                    {
                        RadioButton rdo = new RadioButton();
                        rdo.AutoSize = true;
                        rdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        rdo.Location = new System.Drawing.Point(21, pointB);
                        rdo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        rdo.Name = "RadioButtonEntrante" + b;
                        rdo.Size = new System.Drawing.Size(218, 29);
                        rdo.TabIndex = tabIndexPF;
                        rdo.TabStop = true;
                        rdo.Text = value.Nombre;
                        rdo.UseVisualStyleBackColor = true;
                        this.groupBoxB.Controls.Add(rdo);
                        b++;
                        tabIndexB += 1;
                        pointB += 50;
                    }


            }            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void buttonPM_Click(object sender, EventArgs e)
        {
            string platilloOne = "", platilloTwo = "", platilloThree = "", platilloFour = "";
            foreach (Control ctrl in groupBoxEM.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton radio = ctrl as RadioButton;
                    if (radio.Checked)
                    {
                        platilloOne = radio.Text;
                        break;
                    }
                }
            }
            foreach (Control ctrl in groupBoxPF.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton radio = ctrl as RadioButton;
                    if (radio.Checked)
                    {
                        platilloTwo = radio.Text;
                        break;
                    }
                }
            }
            foreach (Control ctrl in groupBoxP.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton radio = ctrl as RadioButton;
                    if (radio.Checked)
                    {
                        platilloThree = radio.Text;
                        break;
                    }
                }
            }
            foreach (Control ctrl in groupBoxB.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton radio = ctrl as RadioButton;
                    if (radio.Checked)
                    {
                        platilloFour = radio.Text;
                        break;
                    }
                }
            }

            if (platilloOne == "" || platilloTwo == "" || platilloThree == "" || platilloFour == "")
            {
                buttonPM.FlatAppearance.BorderColor = System.Drawing.Color.Red;
                MessageBox.Show("Falta seleccionar una opcion del menu", "Menu Pedido Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                buttonPM.BackColor = Color.Red;
            }
            else
            {
                await controlMenuCarta.Post(Convert.ToInt32(idMesa), platilloOne, platilloTwo, platilloThree, platilloFour, DateTime.Now, 1);
                MessageBox.Show("Pedido Realizado");
                foreach (Control ctrl in groupBoxEM.Controls)
                {
                    if (ctrl is RadioButton)
                    {
                        RadioButton radio = ctrl as RadioButton;
                        if (radio.Checked)
                        {
                            radio.Checked = false;
                            break;
                        }
                    }
                }
                foreach (Control ctrl in groupBoxPF.Controls)
                {
                    if (ctrl is RadioButton)
                    {
                        RadioButton radio = ctrl as RadioButton;
                        if (radio.Checked)
                        {
                            radio.Checked = false;
                            break;
                        }
                    }
                }
                foreach (Control ctrl in groupBoxP.Controls)
                {
                    if (ctrl is RadioButton)
                    {
                        RadioButton radio = ctrl as RadioButton;
                        if (radio.Checked)
                        {
                            radio.Checked = false;
                            break;
                        }
                    }
                }
                foreach (Control ctrl in groupBoxB.Controls)
                {
                    if (ctrl is RadioButton)
                    {
                        RadioButton radio = ctrl as RadioButton;
                        if (radio.Checked)
                        {
                            radio.Checked = false;
                            break;
                        }
                    }
                }
                buttonPM.BackColor = Color.Transparent;
                

            }
        }
    }
}

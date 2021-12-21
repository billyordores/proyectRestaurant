using java.lang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurantApp
{
    public partial class carta : Form
    {
       public decimal mesaId { get; set; }


        public carta(decimal mesaId)
        {
            this.mesaId = mesaId;
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);
                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);
                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Transparent, Color.Transparent);
        }

        private void carta_Load(object sender, EventArgs e)
        {

        }
        private void restaCount(Label label) {
            int count = Convert.ToInt32(label.Text);
            if (count == 0)
            {
                count = 0;
            }
            else
            {

                count = count - 1;

            }
            label.Text = $"{count}";
        }
        private void sumaCount(Label label) {
            label.Text = $"{Convert.ToInt32(label.Text) + 1}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            restaCount(uno);
            sumaTotal();
        }

        private void buttonCountSumOne_Click(object sender, EventArgs e)
        {
            sumaCount(uno);
            sumaTotal();
        }

        private void labelCountOne_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Transparent, Color.Transparent);
        }

        private void groupBox5_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Transparent, Color.Transparent);
        }

        private void groupBox7_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Transparent, Color.Transparent);
        }

        private void groupBox9_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Transparent, Color.Transparent);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            restaCount(dos);
            sumaTotal();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sumaCount(dos);
            sumaTotal();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            restaCount(tres);
            sumaTotal();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sumaCount(tres);
            sumaTotal();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            restaCount(cuatro);
            sumaTotal();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sumaCount(cuatro);
            sumaTotal();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            restaCount(cinco);
            sumaTotal();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            sumaCount(cinco);
            sumaTotal();
        }

        private void labelCountTotal_Click(object sender, EventArgs e)
        {
            
        }
        private void sumaTotal() {
             labelCountTotal.Text = 
             $"{controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(uno.Name))*Convert.ToDouble(uno.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(dos.Name)) * Convert.ToDouble(dos.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(tres.Name)) * Convert.ToDouble(tres.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(cuatro.Name)) * Convert.ToDouble(cuatro.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(cinco.Name)) * Convert.ToDouble(cinco.Text)+ controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(seis.Name)) * Convert.ToDouble(seis.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(siete.Name)) * Convert.ToDouble(siete.Text)+ controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(ocho.Name)) * Convert.ToDouble(ocho.Text)+ controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(nueve.Name)) * Convert.ToDouble(nueve.Text)+ controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unocero.Name)) * Convert.ToDouble(unocero.Text)+ controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unodos.Name)) * Convert.ToDouble(unodos.Text)+ controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unotres.Name)) * Convert.ToDouble(unotres.Text)+ controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unocuatro.Name)) * Convert.ToDouble(unocuatro.Text)+ controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unocinco.Name)) * Convert.ToDouble(unocinco.Text)+ controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unoseis.Name)) * Convert.ToDouble(unoseis.Text)+ controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unosiete.Name)) * Convert.ToDouble(unosiete.Text)+ controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unoocho.Name)) * Convert.ToDouble(unoocho.Text)+ controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unonueve.Name)) * Convert.ToDouble(unonueve.Text)+ controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(doscero.Name)) * Convert.ToDouble(doscero.Text)+ controlMenuCarta.getPrecioAlimento( ConverterLN.stringToInt(dosuno.Name))*Convert.ToDouble(dosuno.Text) +controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(dosdos.Name)) * Convert.ToDouble(dosdos.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(dostres.Name)) * Convert.ToDouble(dostres.Text)+ controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(doscuatro.Name)) * Convert.ToDouble(doscuatro.Text)+ controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(doscinco.Name)) * Convert.ToDouble(doscinco.Text)+ controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(dosseis.Name)) * Convert.ToDouble(dosseis.Text)+ controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(dossiete.Name)) * Convert.ToDouble(dossiete.Text)+ controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(dosocho.Name)) * Convert.ToDouble(dosocho.Text)+ controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(dosnueve.Name)) * Convert.ToDouble(dosnueve.Text)+ ConverterLN.stringToInt(trescero.Name)*Convert.ToDouble(trescero.Text) }";
        }
        private void sumaTotal2(double result)
        {
            labelCountTotal.Text = $"{Convert.ToDouble(labelCountTotal.Text) + result}";
            //$"{controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(uno.Name)) * Convert.ToDouble(uno.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(dos.Name)) * Convert.ToDouble(dos.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(tres.Name)) * Convert.ToDouble(tres.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(cuatro.Name)) * Convert.ToDouble(cuatro.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(cinco.Name)) * Convert.ToDouble(cinco.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(seis.Name)) * Convert.ToDouble(seis.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(siete.Name)) * Convert.ToDouble(siete.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(ocho.Name)) * Convert.ToDouble(ocho.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(nueve.Name)) * Convert.ToDouble(nueve.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unocero.Name)) * Convert.ToDouble(unocero.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unodos.Name)) * Convert.ToDouble(unodos.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unotres.Name)) * Convert.ToDouble(unotres.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unocuatro.Name)) * Convert.ToDouble(unocuatro.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unocinco.Name)) * Convert.ToDouble(unocinco.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unoseis.Name)) * Convert.ToDouble(unoseis.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unosiete.Name)) * Convert.ToDouble(unosiete.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unoocho.Name)) * Convert.ToDouble(unoocho.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unonueve.Name)) * Convert.ToDouble(unonueve.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(doscero.Name)) * Convert.ToDouble(dosuno.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(dosdos.Name)) * Convert.ToDouble(dostres.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(doscuatro.Name)) * Convert.ToDouble(doscuatro.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(doscinco.Name)) * Convert.ToDouble(doscinco.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(dosseis.Name)) * Convert.ToDouble(dosseis.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(dossiete.Name)) * Convert.ToDouble(dossiete.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(dosocho.Name)) * Convert.ToDouble(dosocho.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(dosnueve.Name)) * Convert.ToDouble(dosnueve.Text) + ConverterLN.stringToInt(trescero.Name) * Convert.ToDouble(trescero.Text) }";
        }
        private void restaTotal2(double result)
        {
            labelCountTotal.Text = $"{Convert.ToDouble(labelCountTotal.Text) - result}";
            //$"{controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(uno.Name)) * Convert.ToDouble(uno.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(dos.Name)) * Convert.ToDouble(dos.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(tres.Name)) * Convert.ToDouble(tres.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(cuatro.Name)) * Convert.ToDouble(cuatro.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(cinco.Name)) * Convert.ToDouble(cinco.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(seis.Name)) * Convert.ToDouble(seis.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(siete.Name)) * Convert.ToDouble(siete.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(ocho.Name)) * Convert.ToDouble(ocho.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(nueve.Name)) * Convert.ToDouble(nueve.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unocero.Name)) * Convert.ToDouble(unocero.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unodos.Name)) * Convert.ToDouble(unodos.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unotres.Name)) * Convert.ToDouble(unotres.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unocuatro.Name)) * Convert.ToDouble(unocuatro.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unocinco.Name)) * Convert.ToDouble(unocinco.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unoseis.Name)) * Convert.ToDouble(unoseis.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unosiete.Name)) * Convert.ToDouble(unosiete.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unoocho.Name)) * Convert.ToDouble(unoocho.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(unonueve.Name)) * Convert.ToDouble(unonueve.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(doscero.Name)) * Convert.ToDouble(dosuno.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(dosdos.Name)) * Convert.ToDouble(dostres.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(doscuatro.Name)) * Convert.ToDouble(doscuatro.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(doscinco.Name)) * Convert.ToDouble(doscinco.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(dosseis.Name)) * Convert.ToDouble(dosseis.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(dossiete.Name)) * Convert.ToDouble(dossiete.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(dosocho.Name)) * Convert.ToDouble(dosocho.Text) + controlMenuCarta.getPrecioAlimento(ConverterLN.stringToInt(dosnueve.Name)) * Convert.ToDouble(dosnueve.Text) + ConverterLN.stringToInt(trescero.Name) * Convert.ToDouble(trescero.Text) }";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox13_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Transparent, Color.Transparent);
        }

        private void groupBox17_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Transparent, Color.Transparent);
        }

        private void groupBox21_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Transparent, Color.Transparent);
        }

        private void groupBox19_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Transparent, Color.Transparent);
        }

        private void groupBox15_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Transparent, Color.Transparent);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            restaCount(seis);
            sumaTotal();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            sumaCount(seis);
            sumaTotal();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            restaCount(siete);
            sumaTotal();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            sumaCount(siete);
            sumaTotal();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            restaCount(ocho);
            sumaTotal();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            sumaCount(ocho);
            sumaTotal();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            sumaCount(nueve);
            sumaTotal();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            sumaCount(unocero);
            sumaTotal();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            restaCount(nueve);
            sumaTotal();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            restaCount(unocero);
            sumaTotal();
        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {
            restaCount(unouno);
            sumaTotal();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            restaCount(unodos);
            sumaTotal();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            restaCount(unotres);
            sumaTotal();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            restaCount(unocuatro);
            sumaTotal();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            restaCount(unocinco);
            sumaTotal();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            sumaCount(unocinco);
            sumaTotal();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            sumaCount(unocuatro);
            sumaTotal();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            sumaCount(unotres);
            sumaTotal();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            sumaCount(unodos);
            sumaTotal();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            sumaCount(unouno);
            sumaTotal();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void groupBox56_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void labelCountTwo_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
        //Metodos
        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private  async void button119_Click(object sender, EventArgs e)
        {
            List<AlimentoCantidad> list = new List<AlimentoCantidad>();
            
            if (Convert.ToInt32(uno.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(uno.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(uno.Text)) {});
            }
            else if (Convert.ToInt32(dos.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(dos.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(dos.Text)) { });
            }
            else if (Convert.ToInt32(tres.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(tres.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(tres.Text)) { });
            }
            else if (Convert.ToInt32(cuatro.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(cuatro.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(cuatro.Text)) { });
            }
            else if (Convert.ToInt32(cinco.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(cinco.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(cinco.Text)) { });
            }
            else if (Convert.ToInt32(seis.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(seis.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(seis.Text)) { });
            }
            else if (Convert.ToInt32(siete.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(siete.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(siete.Text)) { });
            }
            else if (Convert.ToInt32(ocho.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(ocho.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(ocho.Text)) { });
            }
            else if (Convert.ToInt32(nueve.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(nueve.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(nueve.Text)) { });
            }
            else if (Convert.ToInt32(unocero.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(unocero.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(unocero.Text)) { });
            }
            else if (Convert.ToInt32(unouno.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(unouno.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(unouno.Text)) { });
            }
            else if (Convert.ToInt32(unodos.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(unodos.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(unodos.Text)) { });
            }
            else if (Convert.ToInt32(unotres.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(unotres.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(unotres.Text)) { });
            }
            else if (Convert.ToInt32(unocuatro.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(unocuatro.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(unocuatro.Text)) { });
            }
            else if (Convert.ToInt32(unocinco.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(unocinco.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(unocinco.Text)) { });
            }
            else if (Convert.ToInt32(unoseis.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(unoseis.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(unoseis.Text)) { });
            }
            else if (Convert.ToInt32(unosiete.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(unosiete.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(unosiete.Text)) { });
            }
            else if (Convert.ToInt32(unoocho.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(unoocho.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(unoocho.Text)) { });
            }
            else if (Convert.ToInt32(unonueve.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(unonueve.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(unonueve.Text)) { });
            }
            else if (Convert.ToInt32(doscero.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(doscero.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(doscero.Text)) { });
            }
            else if (Convert.ToInt32(dosdos.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(dosdos.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(dosdos.Text)) { });
            }
            else if (Convert.ToInt32(dostres.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(dostres.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(dostres.Text)) { });
            }
            else if (Convert.ToInt32(doscuatro.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(doscuatro.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(doscuatro.Text)) { });
            }
            else if (Convert.ToInt32(doscinco.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(doscinco.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(doscinco.Text)) { });
            }
            else if (Convert.ToInt32(dosseis.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(dosseis.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(dosseis.Text)) { });
            }
            else if (Convert.ToInt32(dossiete.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(dossiete.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(dossiete.Text)) { });
            }
            else if (Convert.ToInt32(dosocho.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(dosocho.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(dosocho.Text)) { });
            }
            else if (Convert.ToInt32(cinco.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(dosnueve.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(dosnueve.Text)) { });
            }
            else if (Convert.ToInt32(trescero.Text) > 0)
            {
                int idAlimento = ConverterLN.stringToInt(trescero.Name);
                list.Add(new AlimentoCantidad(idAlimento, Convert.ToInt32(trescero.Text)) { });
            }
            else {
                MessageBox.Show("No tiene ningun alimento seleccionado");
                buttonPCarta.BackColor = Color.Red;            
            }
            DialogResult result = MessageBox.Show("Seguro de realizar el pedido?", "Advertencia", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Pedido Realizado", "PedidoRealizado");
                await controlMenuCarta.PostCarta(Convert.ToInt32(mesaId), list, DateTime.Now);
                buttonPCarta.BackColor = Color.Transparent;
                defaultLabelCount();
            }
        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void button62_Click(object sender, EventArgs e)
        {
            restaCount(unoseis);
            sumaTotal();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            restaCount(unosiete);
            sumaTotal();
        }

        private void button78_Click(object sender, EventArgs e)
        {
            restaCount(unoocho);
            sumaTotal();
        }

        private void button74_Click(object sender, EventArgs e)
        {
            restaCount(unonueve);
            sumaTotal();
        }

        private void button66_Click(object sender, EventArgs e)
        {
            restaCount(doscero);
            sumaTotal();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            sumaCount(unoseis);
            sumaTotal();
        }

        private void button69_Click(object sender, EventArgs e)
        {
            sumaCount(unosiete);
            sumaTotal();
        }

        private void button77_Click(object sender, EventArgs e)
        {
            sumaCount(unoocho);
            sumaTotal();
        }

        private void button73_Click(object sender, EventArgs e)
        {
            sumaCount(unonueve);
            sumaTotal();
        }

        private void button65_Click(object sender, EventArgs e)
        {
            sumaCount(doscero);
            sumaTotal();
        }

        private void button82_Click(object sender, EventArgs e)
        {
            restaCount(dosuno);
            sumaTotal();
        }

        private void button90_Click(object sender, EventArgs e)
        {
            restaCount(dosdos);
            sumaTotal();
        }

        private void button98_Click(object sender, EventArgs e)
        {
            restaCount(dostres);
            sumaTotal();
        }

        private void button94_Click(object sender, EventArgs e)
        {
            restaCount(doscuatro);
            sumaTotal();
        }

        private void button86_Click(object sender, EventArgs e)
        {
            restaCount(doscinco);
            sumaTotal();
        }

        private void button81_Click(object sender, EventArgs e)
        {
            sumaCount(dosuno);
            sumaTotal();
        }

        private void button89_Click(object sender, EventArgs e)
        {
            sumaCount(dosdos);
            sumaTotal();
        }

        private void button97_Click(object sender, EventArgs e)
        {
            sumaCount(dostres);
            sumaTotal();
        }

        private void button93_Click(object sender, EventArgs e)
        {
            sumaCount(doscuatro);
            sumaTotal();
        }

        private void button85_Click(object sender, EventArgs e)
        {
            sumaCount(doscinco);
            sumaTotal();
        }

        private void button102_Click(object sender, EventArgs e)
        {
            restaCount(dosseis);
            sumaTotal();
        }

        private void button110_Click(object sender, EventArgs e)
        {
            restaCount(dossiete);
            sumaTotal();
        }

        private void button118_Click(object sender, EventArgs e)
        {
            restaCount(dosocho);
            sumaTotal();
        }

        private void button114_Click(object sender, EventArgs e)
        {
            restaCount(dosnueve);
            sumaTotal();
        }

        private void button106_Click(object sender, EventArgs e)
        {
            restaCount(trescero);
            sumaTotal();
        }

        private void button101_Click(object sender, EventArgs e)
        {
            sumaCount(dosseis);
            sumaTotal();
        }

        private void button109_Click(object sender, EventArgs e)
        {
            sumaCount(dossiete);
            sumaTotal();
        }

        private void button117_Click(object sender, EventArgs e)
        {
            sumaCount(dosocho);
            sumaTotal();
        }

        private void button113_Click(object sender, EventArgs e)
        {
            sumaCount(dosnueve);
            sumaTotal();
        }

        private void button105_Click(object sender, EventArgs e)
        {
            sumaCount(trescero);
            sumaTotal();
        }
        public void defaultLabelCount() {
            uno.Text = $"{0}";
            dos.Text = $"{0}";
            tres.Text = $"{0}";
            cuatro.Text = $"{0}";
            cinco.Text = $"{0}";
            seis.Text = $"{0}";
            siete.Text = $"{0}";
            ocho.Text = $"{0}";
            nueve.Text = $"{0}";
            unocero.Text = $"{0}";
            unodos.Text = $"{0}";
            unotres.Text = $"{0}";
            unocuatro.Text = $"{0}";
            unocinco.Text = $"{0}";
            unoseis.Text = $"{0}";
            unosiete.Text = $"{0}";
            unoocho.Text = $"{0}";
            unonueve.Text = $"{0}";
            doscero.Text = $"{0}";
            dosuno.Text = $"{0}";
            dosdos.Text = $"{0}";
            dostres.Text = $"{0}";
            doscuatro.Text = $"{0}";
            doscinco.Text = $"{0}";
            dosseis.Text = $"{0}";
            dossiete.Text = $"{0}";
            dosocho.Text = $"{0}";
            dosnueve.Text = $"{0}";
            trescero.Text = $"{0}";

            uno.Text = $"{0}";



        }
    }
}

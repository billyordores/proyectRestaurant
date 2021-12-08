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
        double optionOne = 1.25;
        double optionTwo = 2.25;
        double optionThree = 1.75;
        double optionFour = 1.80;
        double optionFive = 2.36;
        double optionSix = 6.50;
        double optionSeven = 6.35;
        double optionEight = 5.25;
        double optionNine = 6.00;
        double optionTen = 8.45;
        
        
        public carta()
        {
            
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
            restaCount(labelCountOne);
            sumaTotal();
        }

        private void buttonCountSumOne_Click(object sender, EventArgs e)
        {
            sumaCount(labelCountOne);
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
            restaCount(labelCountTwo);
            sumaTotal();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sumaCount(labelCountTwo);
            sumaTotal();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            restaCount(labelCountThree);
            sumaTotal();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sumaCount(labelCountThree);
            sumaTotal();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            restaCount(labelCountFour);
            sumaTotal();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sumaCount(labelCountFour);
            sumaTotal();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            restaCount(labelCountFive);
            sumaTotal();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            sumaCount(labelCountFive);
            sumaTotal();
        }

        private void labelCountTotal_Click(object sender, EventArgs e)
        {
            
        }
        private void sumaTotal() {
             labelCountTotal.Text = $"{optionOne * Convert.ToDouble(labelCountOne.Text) + optionTwo * Convert.ToDouble(labelCountTwo.Text) +  optionThree * Convert.ToDouble(labelCountThree.Text) + optionFour * Convert.ToDouble(labelCountFour.Text) + optionFive * Convert.ToDouble(labelCountFive.Text) + optionSix * Convert.ToDouble(labelCountSix.Text) + optionSeven * Convert.ToDouble(labelCountSeven.Text) + optionEight * Convert.ToDouble(labelCountEight.Text) + optionNine * Convert.ToDouble(labelCountNine.Text) + optionTen * Convert.ToDouble(labelCountTen.Text)}";
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
            restaCount(labelCountSix);
            sumaTotal();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            sumaCount(labelCountSix);
            sumaTotal();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            restaCount(labelCountSeven);
            sumaTotal();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            sumaCount(labelCountSeven);
            sumaTotal();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            restaCount(labelCountEight);
            sumaTotal();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            sumaCount(labelCountEight);
            sumaTotal();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            sumaCount(labelCountNine);
            sumaTotal();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            sumaCount(labelCountTen);
            sumaTotal();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            restaCount(labelCountNine);
            sumaTotal();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            restaCount(labelCountTen);
            sumaTotal();
        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {
            restaCount(labelCountEleven);
            sumaTotal();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            restaCount(labelCountTwelve);
            sumaTotal();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            restaCount(labelCountThirteen);
            sumaTotal();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            restaCount(labelCountFourteen);
            sumaTotal();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            restaCount(labelCountFifteen);
            sumaTotal();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            sumaCount(labelCountFifteen);
            sumaTotal();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            sumaCount(labelCountFourteen);
            sumaTotal();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            sumaCount(labelCountThirteen);
            sumaTotal();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            sumaCount(labelCountTwelve);
            sumaTotal();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            sumaCount(labelCountEleven);
            sumaTotal();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void groupBox56_Enter(object sender, EventArgs e)
        {

        }
    }
}

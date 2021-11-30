using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurantApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void openPanel(object panelOne) {
            if (this.panelConteiner.Controls.Count>0) {
                this.panelConteiner.Controls.RemoveAt(0);
            }
            Form pOne = panelOne as Form;
            pOne.TopLevel = false;
            pOne.Dock = DockStyle.Fill;
            this.panelConteiner.Controls.Add(pOne);
            this.panelConteiner.Tag = pOne;
            pOne.Show();
        }

        private void panelConteiner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openPanel(new principal());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openPanel(new menu());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openPanel(new carta());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openPanel(new pedidos());
        }
    }
}

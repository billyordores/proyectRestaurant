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

namespace controlChef
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openPanel(new PedidosForm());
        }
        private void openPanel(object panelOne)
        {
            if (this.panelContainerChef.Controls.Count > 0)
            {
                this.panelContainerChef.Controls.RemoveAt(0);
            }
            Form pOne = panelOne as Form;
            pOne.TopLevel = false;
            labelWelcome.Visible = false;
            pictureBoxWelcome.Visible = false;
            pOne.Dock = DockStyle.Fill;
            this.panelContainerChef.Controls.Add(pOne);
            this.panelContainerChef.Tag = pOne;
            pOne.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openPanel(new HisorialForm());
        }
    }
}

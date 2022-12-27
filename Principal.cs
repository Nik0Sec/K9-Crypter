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

namespace K9
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            customdiseño();
        }
        //Estos DLL imports son para el arrastre de ventana haciendo click en cualquier parte del menú/inicio
        [DllImport("user32.dll")]
        public extern static void ReleaseCapture();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void customdiseño()
        {

            paneldelsubmenuherra.Visible = false;

        }

        private Form activeForm = null;
        private void abrirformhijo(Form childForm)
        {

            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock=DockStyle.Fill;
            panelprincipalhijo.Controls.Add(childForm);
            panelprincipalhijo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void escondersubmenu()
        {

            if (paneldelsubmenuherra.Visible == true)
                paneldelsubmenuherra.Visible = false;
        
        }


        private void mostrarsubmenu(Panel panel2)
        {
            if (panel2.Visible == false)
            {
                escondersubmenu();
                panel2.Visible = true;
            }
            else
                panel2.Visible = false;
        
        }

        private void panelmenulateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var W = 600;
            if (W == label1.Left)
            {

                label1.Left = -300;


            }
            else 
            
            {

                label1.Left = label1.Left + 2;
            }
        }

        private void toolsmenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
            abrirformhijo(new Crypt());

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            label2.Text = DateTime.Now.ToShortTimeString();

            label3.Text = DateTime.Now.ToLongDateString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(paneldelsubmenuherra);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void mover(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void mover1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void mover2(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            abrirformhijo(new b64());
            escondersubmenu();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            escondersubmenu();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            escondersubmenu();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            escondersubmenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirformhijo(new AnonFile());
            
            escondersubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirformhijo(new ConvertirPayload());
            escondersubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            escondersubmenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            escondersubmenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            escondersubmenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            escondersubmenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            escondersubmenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            escondersubmenu();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            escondersubmenu();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            escondersubmenu();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            escondersubmenu();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            escondersubmenu();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            escondersubmenu();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            escondersubmenu();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            escondersubmenu();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer2.Start();

            label3.Text = DateTime.Now.ToLongDateString();
        }

        private void panelprincipalhijo_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void movermain(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Acercade());

        }

        private void button10_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Assembly());
        }
    }
}

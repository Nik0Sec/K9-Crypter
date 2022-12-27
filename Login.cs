using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace K9
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }
        //Estos DLL imports son para el arrastre de ventana haciendo click en cualquier parte del menú/inicio
        [DllImport("user32.dll")]
        public extern static void ReleaseCapture();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //Estas funciones dibujan las líneas del inicio de sesión (Debajo de USUARIO/CONTRASEÑA)
            Graphics gra = this.panel1.CreateGraphics();
            Pen blackPen = new Pen(Color.Gray, 1);


            int x1 = 10;
            int x2 = 400;

            int y1 = 100;
            int y2 = 100;

            e.Graphics.DrawLine(blackPen, x1, y1, x2, y2);


            int w1 = 10;
            int w2 = 400;

            int e1 = 200;
            int e2 = 200;

            e.Graphics.DrawLine(blackPen, w1, e1, w2, e2);

        }

        private void usuario_Enter(object sender, EventArgs e)
        {
            if (usuario.Text == "USUARIO")
            {
                usuario.Text = "";
                usuario.ForeColor = Color.LightGray;


            }
        }

        private void usuario_Leave(object sender, EventArgs e)
        {
            if (usuario.Text == "")
            {
                usuario.Text = "USUARIO";

                usuario.ForeColor = Color.LightGray;


            }

        }

        private void contra_enter(object sender, EventArgs e)
        {
            if (contrase.Text == "CONTRASEÑA")
            {
                contrase.Text = "";
                contrase.ForeColor = Color.LightGray;
                contrase.UseSystemPasswordChar = true; 



            }
        }

        private void contra_leave(object sender, EventArgs e)
        {
            if (contrase.Text == "")
            {
                contrase.Text = "CONTRASEÑA";

                contrase.ForeColor = Color.LightGray;

                contrase.UseSystemPasswordChar = true;

            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            //Aquí se verifica que el usuario y contraseña sean correctos, lo ideal sería tener una DB obviamente.
            if (contrase.Text.Trim() == String.Empty && contrase.Text.All(Char.IsLetter))
            {
                MessageBox.Show("No es la contraseña");

            }
            else if (contrase.Text.Trim() == "TEST" && usuario.Text.Trim() == "TEST")
            {
                //Si la contraseña y usuario son correctos, se muestra un mensaje de "Bienvenido" y se cierra el form actual para abrir los subsiguientes.
                MessageBox.Show("Bienvenido");
                this.Hide();
                Form mostrarmenuprincipal = new CargaIntermediaCalavera();
                mostrarmenuprincipal.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("No es la contraseña");

            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel_arrastre(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void arraste_panel(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

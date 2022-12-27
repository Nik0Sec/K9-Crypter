using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K9
{
    public partial class Assembly : Form
    {
        public Assembly()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        
        private string RandomString(int length)
        {
            string pool = "abcdefghijklmnopqrstuvwxyz0123456789";
            pool += pool.ToUpper();
            string tmp = "";
            Random R = new Random();
            for (int x = 0; x < length; x++)
            {
                tmp += pool[R.Next(0, pool.Length)].ToString();
            }
            return tmp;
        }

        private string RandomNumber(int _length)
        {
            //Making a random number for the random assemblys version
            string pool = "0123456789";
            pool += pool.ToUpper();
            string tmp = "";
            Random R = new Random();
            for (int x = 0; x < _length; x++)
            {
                tmp += pool[R.Next(0, pool.Length)].ToString();
            }
            return tmp;
        }

        string stub = Properties.Resources.stubahorasi;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //No cambia los atributos en el .exe final, arreglar eso también 
                titulo.Text = RandomString(9);
                descripcion.Text = RandomString(16);
                compania.Text = RandomString(19);
                trademark.Text = RandomString(21);
                copyright.Text = RandomString(18);
                producto.Text = (RandomNumber(1) + "." + RandomNumber(2) + "." + RandomNumber(1) + "." + RandomNumber(1));
                version_archivo.Text = (RandomNumber(1) + "." + RandomNumber(1) + "." + RandomNumber(2) + "." + RandomNumber(2));
                descripcion.Text = RandomString(17);
                version.Text = RandomString(15);


                stub = stub.Replace("[titulo]", titulo.Text);
                stub = stub.Replace("[compania]", compania.Text);
                stub = stub.Replace("[producto]", producto.Text);
                stub = stub.Replace("[copyright]", copyright.Text);
                stub = stub.Replace("[trademark]", trademark.Text);
                stub = stub.Replace("[descripcion]", descripcion.Text);
                stub = stub.Replace("[versionarchivo]", version.Text);
            }
            else
            {
                stub = stub.Replace("[titulo]", "Build");
                stub = stub.Replace("[compania]", "Build");
                stub = stub.Replace("[producto]", "Build");
                stub = stub.Replace("[copyright]", "Build");
                stub = stub.Replace("[trademark]", "Build");
                stub = stub.Replace("[descripcion]", "Build");
                stub = stub.Replace("[versionarchivo]", "1.0.0.0");
            }
        }
    }
}

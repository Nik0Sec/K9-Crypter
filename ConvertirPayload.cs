using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace K9
{
    public partial class ConvertirPayload : Form
    {
        public ConvertirPayload()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        public static string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/RawPayload.bin";
        private void button2_Click(object sender, EventArgs e)
        {
         
            var convertirbyte = System.Text.Encoding.UTF8.GetBytes(cajacargautil.Text);
            File.WriteAllBytes(ruta, convertirbyte);
            MessageBox.Show(string.Format("Todo bien, binario guardado en: {0}", ruta));
        }

        private void cajacargautil_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K9
{
    public partial class AnonFile : Form
    {
        public AnonFile()
        {
            InitializeComponent();
        }
        static string CreateDownloadLink(string File) 
        {
            string ReturnValue = string.Empty;
            try
            {
                using (WebClient Client = new WebClient())
                {
                    byte[] Response = Client.UploadFile("https://api.anonfiles.com/upload", File);
                    string ResponseBody = Encoding.ASCII.GetString(Response);
                    if (ResponseBody.Contains("\"error\": {"))
                    {
                        ReturnValue += "There was a erorr while uploading the file.\r\n";
                        ReturnValue += "Error message: " + ResponseBody.Split('"')[7] + "\r\n";
                    }
                    else
                    {
                        ReturnValue += "Download link: " + ResponseBody.Split('"')[15] + "\r\n";
                        ReturnValue += "File name: " + ResponseBody.Split('"')[25] + "\r\n";
                        MessageBox.Show(ReturnValue);
                        
                    }
                }
            }
            catch (Exception Exception)
            {
                ReturnValue += "Exception Message:\r\n" + Exception.Message + "\r\n";
            }
            return ReturnValue;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
           
            { 
            
                cajabuscar1.Text = openfiledialog.FileName;
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lol = CreateDownloadLink(cajabuscar1.Text);
            cajaURL.Text = lol.Replace("Download link: ", " ").Replace("File name: ", "                                               "); 
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K9
{
    public partial class CargaIntermediaCalavera : Form
    {
        public CargaIntermediaCalavera()
        {
            InitializeComponent();
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Wena();
            
            
        }
        
        public void testc()
        {
            Timer t = new Timer();
            t.Interval = 2000;
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
     

        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
                
                this.Close();
            
        }

        Timer t = new Timer();

        private void Wena()
        {
            t.Interval = 1500;
            t.Tick += new EventHandler(OnTimerTicked);
            t.Start();
            
        }

        public void OnTimerTicked(object sender, EventArgs e)
        {
            t.Stop();
            this.Hide();
            Form mostrarmenuprincipal = new Principal();
            mostrarmenuprincipal.ShowDialog();

        }



    }


}

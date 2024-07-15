using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4th_sem_proj_beta
{
    public partial class Splashscreen : Form
    {
        int interval = 0;
        public Splashscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (interval < 30)
            {
                interval++;
                progressBar1.Value = interval;
                label1.Text = "Loading" + interval + "%";
            }
            else
            {
                timer1.Enabled = false;
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
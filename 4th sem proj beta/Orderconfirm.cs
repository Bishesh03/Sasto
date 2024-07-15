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
    
    public partial class Orderconfirm : Form
    {
        int interval = 0;
        public Orderconfirm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (interval < 23)
            {
                interval++;
                progressBar1.Value = interval;
                label1.Text = "Loading" + interval + "%";
            }
            else
            {
                timer1.Enabled = false;
                Main form = new Main();
                form.Show();
                this.Hide();


            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Orderconfirm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
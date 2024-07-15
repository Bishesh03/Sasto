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
    public partial class Lalitpur : Form
    {
        public Lalitpur()
        {
            InitializeComponent();
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void Lalitpur_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main ok = new Main();
            ok.Show();
            this.Hide();
        }

        private void lblabout_Click(object sender, EventArgs e)
        {
            Aboutus ok = new Aboutus();
            ok.Show();
            this.Hide();
        }

        private void lblareas_Click(object sender, EventArgs e)
        {
            AvailableAreas ok = new AvailableAreas();
            ok.Show();
            this.Hide();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            HowToOrder ok = new HowToOrder();
            ok.Show();
            this.Hide();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            Fqs ok = new Fqs();
            ok.Show();
            this.Hide();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            ContactUs ok = new ContactUs();
            ok.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Devalaya ok = new Devalaya();
            ok.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Devalaya ok = new Devalaya();
            ok.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Tokyo_Ramen_House ok = new Tokyo_Ramen_House();
            ok.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Tokyo_Ramen_House ok = new Tokyo_Ramen_House();
            ok.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            panel9.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            panel9.Visible = false;
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.Red;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.Transparent;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Tan;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Main ok = new Main();
            ok.Show();
            this.Hide();
        }
    }
}

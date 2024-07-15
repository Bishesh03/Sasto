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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            pictureBox8.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            lblKathmandu.Visible = false;
            lblLalitpur.Visible = false;
            lblBhakatapur.Visible = false;
            Dropdown.Visible = false;

            Dropdown_control.Visible = !Dropdown_control.Visible;

            search_ktm.Visible = false;
            search_bhakatapur.Visible = false;
            search_lalitpur.Visible = false;



        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {


        }

        private void pictureBox8_MouseEnter_1(object sender, EventArgs e)
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

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Bhaktapur ok = new Bhaktapur();
            ok.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Lalitpur ok = new Lalitpur();
            ok.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Ktm ok = new Ktm();
            ok.Show();
            this.Hide();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Mari ok = new Mari();
            ok.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Roadhouse ok = new Roadhouse();
            ok.Show();
            this.Hide();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Tokyo_Ramen_House ok = new Tokyo_Ramen_House();
            ok.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Devalaya ok = new Devalaya();
            ok.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Bhaktapur ok = new Bhaktapur();
            ok.Show();
            this.Hide();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Koto ok = new Koto();
            ok.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Koto ok = new Koto();
            ok.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Lalitpur ok = new Lalitpur();
            ok.Show();
            this.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Burgerhouse ok = new Burgerhouse();
            ok.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Devalaya ok = new Devalaya();
            ok.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Ktm ok = new Ktm();
            ok.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblAreas(object sender, EventArgs e)
        {
            AvailableAreas ok = new AvailableAreas();
            ok.Show();
            this.Hide();
        }

        private void lblAbout(object sender, EventArgs e)
        {
            Aboutus ok = new Aboutus();
            ok.Show();
            this.Hide();
        }

        private void lblHowToOrder(object sender, EventArgs e)
        {
            HowToOrder ok = new HowToOrder();
            ok.Show();
            this.Hide();
        }

        private void lblFaqs(object sender, EventArgs e)
        {
            Fqs ok = new Fqs();
            ok.Show();
            this.Hide();
        }

        private void lblCotact(object sender, EventArgs e)
        {
            ContactUs ok = new ContactUs();
            ok.Show();
            this.Hide();
        }

        private void lblLearnMore(object sender, EventArgs e)
        {
            Aboutus ok = new Aboutus();
            ok.Show();
            this.Hide();
        }

        private void S3_Click(object sender, EventArgs e)
        {
            Lalitpur ok = new Lalitpur();
            ok.Show();
            this.Hide();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            Search.Visible = false;
            lblKathmandu.Visible = true;
            lblLalitpur.Visible = false;
            lblBhakatapur.Visible = false;

            Dropdown.Visible = false;

            okokoko.Visible = false;
            search_bhakatapur.Visible =false;
            search_lalitpur.Visible = false;
            search_ktm.Visible = true;


        }

        private void B2_Click(object sender, EventArgs e)
        {
            lblKathmandu.Visible = false;
            lblLalitpur.Visible = true;
            lblBhakatapur.Visible = false;

            Dropdown.Visible = false;
            Search.Visible = false;

            okokoko.Visible = false;
            search_bhakatapur.Visible = false;
            search_lalitpur.Visible = true;
            search_ktm.Visible = false;
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Search.Visible = false;
            lblKathmandu.Visible = false;
            lblLalitpur.Visible = false;
            lblBhakatapur.Visible = true;

            Dropdown.Visible = false;

            okokoko.Visible = false;
            search_bhakatapur.Visible = true;
            search_lalitpur.Visible = false;
            search_ktm.Visible = false;
        }

        private void PL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PL_Click(object sender, EventArgs e)
        {
            Dropdown.Visible = !Dropdown.Visible;

        }

        private void hati_Click(object sender, EventArgs e)
        {
            Bhaktapur ok = new Bhaktapur();
            ok.Show();
            this.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Dropdown.Visible = !Dropdown.Visible;
        }

        private void search_ktm_Click(object sender, EventArgs e)
        {
            Ktm ok = new Ktm();
            ok.Show();
            this.Hide();
        }

        private void search_bhakatapur_Click(object sender, EventArgs e)
        {
            Bhaktapur ok = new Bhaktapur();
            ok.Show();
            this.Hide();

        }

        private void search_lalitpur_Click(object sender, EventArgs e)
        {
            Lalitpur ok = new Lalitpur();
            ok.Show();
            this.Hide();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            Form1 ok = new Form1();
            ok.Show();
            this.Hide();
        }
    }
}

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
    public partial class Admin2 : Form
    {
        private readonly UserControlAdminDashboard dashboard;
        private readonly UserControlAdminCharts chart;
        private readonly UserControlAdminUser user;
       // private readonly UserControlAdminTable table;


        public Admin2()
        {
            InitializeComponent();


            dashboard = new UserControlAdminDashboard();
            panel3.Controls.Add(dashboard);

            chart = new UserControlAdminCharts();
            panel3.Controls.Add(chart);

            user = new UserControlAdminUser();
            panel3.Controls.Add(user);

            // table = new UserControlAdminTable();
            // panel3.Controls.Add(table);



            dashboard.Visible = true;
            chart.Visible = false;
            user.Visible = false;
            //table.Visible = false;

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Click(object sender, EventArgs e)
        {
            Form1 ok = new Form1();
            ok.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            dashboard.Visible = true;
            chart.Visible = false;
            user.Visible = false;
            //table.Visible = false;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Click(object sender, EventArgs e)
        {
            dashboard.Visible = false;
            chart.Visible = false;
            user.Visible = false;
            //table.Visible = true;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            dashboard.Visible = false;
            chart.Visible = true;
            user.Visible = false;
            //table.Visible = false;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            dashboard.Visible = false;
            chart.Visible = false;
            user.Visible = true;
            //table.Visible = false;
        }

        private void panel7_Click_1(object sender, EventArgs e)
        {
            dashboard.Visible = false;
            chart.Visible = false;
            user.Visible = true;
            //table.Visible = false;
        }
    }
}

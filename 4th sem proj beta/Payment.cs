using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _4th_sem_proj_beta
{
    public partial class Payment : Form
    {


        private string connectionString = "server=localhost;user=root;database=sastomasto;port=3306;password=@Mysqlserver;";
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO payment (phone, name, city, deliveryaddr, couponcode, specialinstruction) VALUES (@phone, @name, @city, @deliveryaddr, @couponcode, @specialinstruction)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@phone", txtPhoneNumber.Text);
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@city", txtCity.Text);
                        cmd.Parameters.AddWithValue("@deliveryaddr", txtaddress.Text);
                        cmd.Parameters.AddWithValue("@couponcode", cCode.Text);
                        cmd.Parameters.AddWithValue("@specialinstruction", lblinstruction.Text);
                        cmd.ExecuteNonQuery();


                        Confirm ok = new Confirm();
                        ok.Show();


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }








            
        }
    }
}

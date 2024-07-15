using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;



namespace _4th_sem_proj_beta
{
    public partial class Signinpage : Form



    {
        private string connectionString = "server=localhost;user=root;database=sastomasto;port=3306;password=@Mysqlserver;";

        public Signinpage()
        {
            InitializeComponent();
        }

        private void Signinpage_Load(object sender, EventArgs e)
        {

        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO user_data (email, username, phone, password) VALUES (@Email, @Name, @PhoneNumber, @Password)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registration successful!");

                        Form1 ok = new Form1();
                        ok.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                
            }


          

        }

        private void textBoxsignupname_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelsignup_Click(object sender, EventArgs e)
        {
            Form1 ok = new Form1();
            ok.Show();
            this.Hide();
        }

        private void signupbutton_Enter(object sender, EventArgs e)
        {
          
        }
    }
}


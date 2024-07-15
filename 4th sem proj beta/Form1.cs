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
    public partial class Form1 : Form
    {
        private string connectionString = "server=localhost;user=root;database=sastomasto;port=3306;password=@Mysqlserver;";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginpic.Visible = false;

        }

        private void labelpassword_Click(object sender, EventArgs e)
        {

        }

        private void textBoxemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void noaccount_Click(object sender, EventArgs e)
        {

        }

        private void loginpic_Click(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsAdmin(email, password))
            {
                Admin2 admin = new Admin2();
                admin.Show();
                this.Hide();
            }
            else if (AuthenticateUser(email, password))
            {
                Main ok = new Main();
                ok.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool AuthenticateUser(string email, string password)
        {
            bool isAuthenticated = false;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM user_data WHERE email = @Email AND password = @Password";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        isAuthenticated = count > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return isAuthenticated;
        }

        private bool IsAdmin(string email, string password)
        {
            bool isAdmin = false;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM admin WHERE email = @Email AND password = @Password";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        isAdmin = count > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return isAdmin;
        }

        private void labelsignup_Click(object sender, EventArgs e)
        {
            Signinpage ok = new Signinpage();
            ok.Show();
            this.Hide();
        }

        private void labelforgotpwd_Click(object sender, EventArgs e)
        {
            Signinpage ok = new Signinpage();
            ok.Show();
            this.Hide();
        }
    }





   
}


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
    public partial class table : UserControl
    {
        private string connectionString = "server=localhost;user=root;database=sastomasto;port=3306;password=@Mysqlserver;";
        public table()
        {
            InitializeComponent();
        }

        private void table_Load(object sender, EventArgs e)
        {

        }
    }
}

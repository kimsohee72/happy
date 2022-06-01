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

namespace Teamproject1
{
    public partial class favorite : Form
    {
        MySQL mysql = new MySQL("127.0.0.1", "sys", "root", "rlathgml72");

        public favorite()
        {
            InitializeComponent();
        }

        private void favorite_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = mysql.Connection();
            string sql = "select ";
        }
    }
}

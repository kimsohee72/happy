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
using System.Text.RegularExpressions;

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
            string sql = "select * from login2";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = new MySqlCommand(sql, connection).ExecuteReader();

            while (reader.Read())
            {
                textBox1.Text += reader[0].ToString() + "\r\n" + reader[1].ToString() + " " + reader[2].ToString() + "\r\n \r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform1 ma = new mainform1();
            ma.Show();
        }
    }
}

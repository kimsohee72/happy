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
using System.IO;

namespace Teamproject1
{
    public partial class showfashionform3 : Form
    {
        MySQL mysql = new MySQL("127.0.0.1", "sys", "root", "rlathgml72");
        //bool result = false;
        public showfashionform3()
        {
            InitializeComponent();
        }

        private void toprecommand_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = mysql.Connection();
            string sql;
            int tem = 26;
            if ((-4 <= tem) && (tem <= 0))
            {
                sql = "select * from people_main where -4<=temperature && temperature<=0";
}

            else if ((1 <= tem) && (tem <= 5))
            {
                sql = "select * from people_main where 1<=temperature && temperature <=5";
            }

            else if ((6 <= tem) && (tem <= 10))
            {
                sql = "select * from people_main where 6<= temperature && temperature <=10";
            }
            else if ((11 <= tem) && (tem <= 15))
            {
                sql = "select * from people_main where 11<= temperature && temperature <=15";
            }
            else if ((16 <= tem) && (tem <= 20))
            {
                sql = "select * from people_main where 16<= temperature && temperature <=20";
            }
            else if ((21 <= tem) && (tem <= 25))
            {
                sql = "select * from people_main where 21<= temperature && temperature <=25";
            }
            else if ((26 <= tem) && (tem <= 30))
            {
                sql = "select * from people_main where 26<=temperature && temperature <=30";
            }
            else if ((31 <= tem) && (tem <= 35))
            {
                sql = "select * from people_main where 31<=temperature && temperature <=35";
            }
            else if ((36 <= tem) && (tem <= 40))
            {
                sql = "select * from people_main where 36<= temperature && temperature <=40";
            }
            else
            {
                sql = " ";
            }
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = new MySqlCommand(sql, connection).ExecuteReader();

            while (reader.Read())
            {
                var weather = "";
                string Tcloth = reader[4].ToString();
                string pick = "오늘은 날씨가 " + weather + "이므로 " + Tcloth + "를 입는 것이 좋습니다!";
                extradesign.Text = pick+"\r\n";
                Regex regex = new Regex(Tcloth);
                MatchCollection mc = regex.Matches(extradesign.Text);

                int Coursor = extradesign.SelectionStart;

                foreach(Match match in mc)
                {
                    int start = match.Index;
                    int stop = match.Length;

                    extradesign.Select(start, stop);
                    extradesign.SelectionColor = Color.Red;
                    extradesign.SelectionStart = Coursor;
                    extradesign.SelectionColor = Color.Black;
                }
            }
            reader.Close();
            connection.Close();

        }

        private void bottomrecommand_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = mysql.Connection();
            int tem = 26;
            string sql;
            if ((-4 <= tem) && (tem <= 0))
            {
                sql = "select * from people_main where -4<=temperature && temperature<=0";
            }

            else if ((1 <= tem) && (tem <= 5))
            {
                sql = "select * from people_main where 1<=temperature && temperature <=5";
            }

            else if ((6 <= tem) && (tem <= 10))
            {
                sql = "select * from people_main where 6<= temperature && temperature <=10";
            }
            else if ((11 <= tem) && (tem <= 15))
            {
                sql = "select * from people_main where 11<= temperature && temperature <=15";
            }
            else if ((16 <= tem) && (tem <= 20))
            {
                sql = "select * from people_main where 16<= temperature && temperature <=20";
            }
            else if ((21 <= tem) && (tem <= 25))
            {
                sql = "select * from people_main where 21<= temperature && temperature <=25";
            }
            else if ((26 <= tem) && (tem <= 30))
            {
                sql = "select * from people_main where 26<=temperature && temperature <=30";
            }
            else if ((31 <= tem) && (tem <= 35))
            {
                sql = "select * from people_main where 31<=temperature && temperature <=35";
            }
            else if ((36 <= tem) && (tem <= 40))
            {
                sql = "select * from people_main where 36<= temperature && temperature <=40";
            }
            else
            {
                sql = " ";
            }
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = new MySqlCommand(sql, connection).ExecuteReader();

            while (reader.Read())
            {
                
                var Tcloth = reader[4].ToString();
                var Bcloth = reader[6].ToString();
                string pick = Tcloth + "와 함께" + Bcloth + "을 입는 것을 추천합니다";
                extradesign.Text += pick + "\r\n";
                Regex regex1 = new Regex(Bcloth);
                MatchCollection m = regex1.Matches(extradesign.Text);

                int Coursor = extradesign.SelectionStart;

                foreach (Match match in m)
                {
                    int start = match.Index;
                    int stop = match.Length;

                    extradesign.Select(start, stop);
                    extradesign.SelectionColor = Color.Blue;
                    extradesign.SelectionStart = Coursor;
                    extradesign.SelectionColor = Color.Black;
                }
            }
            reader.Close();
            connection.Close();
        }

        private void outer_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = mysql.Connection();
            string sql;
            int tem = 26;
            if ((-4 <= tem) && (tem <= 0))
            {
                sql = "select * from people_main where -4<=temperature && temperature<=0";
            }

            else if ((1 <= tem) && (tem <= 5))
            {
                sql = "select * from people_main where 1<=temperature && temperature <=5";
            }

            else if ((6 <= tem) && (tem <= 10))
            {
                sql = "select * from people_main where 6<= temperature && temperature <=10";
            }
            else if ((11 <= tem) && (tem <= 15))
            {
                sql = "select * from people_main where 11<= temperature && temperature <=15";
            }
            else if ((16 <= tem) && (tem <= 20))
            {
                sql = "select * from people_main where 16<= temperature && temperature <=20";
            }
            else if ((21 <= tem) && (tem <= 25))
            {
                sql = "select * from people_main where 21<= temperature && temperature <=25";
            }
            else if ((26 <= tem) && (tem <= 30))
            {
                sql = "select * from people_main where 26<=temperature && temperature <=30";
            }
            else if ((31 <= tem) && (tem <= 35))
            {
                sql = "select * from people_main where 31<=temperature && temperature <=35";
            }
            else if ((36 <= tem) && (tem <= 40))
            {
                sql = "select * from people_main where 36<= temperature && temperature <=40";
            }
            else
            {
                sql = " ";
            }
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = new MySqlCommand(sql, connection).ExecuteReader();

            while (reader.Read())
            {
                var Tcloth = reader[4].ToString();
                var Bcloth = reader[6].ToString();
                var outer = reader[5].ToString();
                string pick;
                if(outer != "")
                    pick = "오늘 날씨에는 " + outer + "를 입는 것이 좋겠어요";
                else
                    pick = "아웃터가 없어도 괜찮을 날씨 입니당~!";
                extradesign.Text += pick + "\r\n";
            }
            reader.Close();
            connection.Close();
        }

        private void showfasionmainbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform1 mainform2= new mainform1();
            mainform2.Show();


        }

        private void extra_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = mysql.Connection();
            string sql = "SELECT * FROM people_main where temperature=\"26\" ";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = new MySqlCommand(sql, connection).ExecuteReader();

            while (reader.Read())
            {

                var Tcloth = reader[4].ToString();
                var Bcloth = reader[6].ToString();
                string c = ".\\cloth\\" + Tcloth + " " + Bcloth + ".jfif";
                expicture1.Image = Image.FromFile(c);
            }
            reader.Close();
            connection.Close();
        }
    }
}

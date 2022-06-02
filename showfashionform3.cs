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
using System.Xml;
using System.Net;

namespace Teamproject1
{
    public partial class showfashionform3 : Form
    {
        string Tcloth = "", Bcloth = "", Outer = "", weather = "",Date;
        double tem;
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
            if ((-4 <= tem) && (tem <= 0))
            {
                sql = "select * from people_main where -4<=temperature && temperature<=0 limit 1";
}

            else if ((1 <= tem) && (tem <= 5))
            {
                sql = "select * from people_main where 1<=temperature && temperature <=5 limit 1";
            }

            else if ((6 <= tem) && (tem <= 10))
            {
                sql = "select * from people_main where 6<= temperature && temperature <=10 limit 1";
            }
            else if ((11 <= tem) && (tem <= 15))
            {
                sql = "select * from people_main where 11<= temperature && temperature <=15 limit 1";
            }
            else if ((16 <= tem) && (tem <= 20))
            {
                sql = "select * from people_main where 16<= temperature && temperature <=20 limit 1";
            }
            else if ((21 <= tem) && (tem <= 25))
            {
                sql = "select * from people_main where 21<= temperature && temperature <=25 limit 1";
            }
            else if ((26 <= tem) && (tem <= 30))
            {
                sql = "select * from people_main where 26<=temperature && temperature <=30 limit 1";
            }
            else if ((31 <= tem) && (tem <= 35))
            {
                sql = "select * from people_main where 31<=temperature && temperature <=35 limit 1";
            }
            else if ((36 <= tem) && (tem <= 40))
            {
                sql = "select * from people_main where 36<= temperature && temperature <=40 limit 1";
            }
            else
            {
                sql = " ";
            }
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = new MySqlCommand(sql, connection).ExecuteReader();

                while (reader.Read())
                {
                    Tcloth = reader[4].ToString();
                    string pick = "오늘은 날씨가 " + weather + "이므로 " + Tcloth + "를 입는 것이 좋습니다!";
                    extradesign.Text = pick + "\r\n";
                    Regex regex = new Regex(Tcloth);
                    MatchCollection mc = regex.Matches(extradesign.Text);

                    int Coursor = extradesign.SelectionStart;

                    foreach (Match match in mc)
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
            catch
            {
                string pick = "오늘은 날씨가 맑음이므로 크롭티를 입는게 좋을 것 같습니다 (데이터베이스 연결 안됨)";
                extradesign.Text = pick + "\r\n";
            }
            

        }

        private void bottomrecommand_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = mysql.Connection();
            string sql;
            if ((-4 <= tem) && (tem <= 0))
            {
                sql = "select * from people_main where -4<=temperature && temperature<=0 limit 1";
            }

            else if ((1 <= tem) && (tem <= 5))
            {
                sql = "select * from people_main where 1<=temperature && temperature <=5 limit 1";
            }

            else if ((6 <= tem) && (tem <= 10))
            {
                sql = "select * from people_main where 6<= temperature && temperature <=10 limit 1";
            }
            else if ((11 <= tem) && (tem <= 15))
            {
                sql = "select * from people_main where 11<= temperature && temperature <=15 limit 1";
            }
            else if ((16 <= tem) && (tem <= 20))
            {
                sql = "select * from people_main where 16<= temperature && temperature <=20 limit 1";
            }
            else if ((21 <= tem) && (tem <= 25))
            {
                sql = "select * from people_main where 21<= temperature && temperature <=25 limit 1";
            }
            else if ((26 <= tem) && (tem <= 30))
            {
                sql = "select * from people_main where 26<=temperature && temperature <=30 limit 1";
            }
            else if ((31 <= tem) && (tem <= 35))
            {
                sql = "select * from people_main where 31<=temperature && temperature <=35 limit 1";
            }
            else if ((36 <= tem) && (tem <= 40))
            {
                sql = "select * from people_main where 36<= temperature && temperature <=40 limit 1";
            }
            else
            {
                sql = " ";
            }
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = new MySqlCommand(sql, connection).ExecuteReader();

                while (reader.Read())
                {

                    Tcloth = reader[4].ToString();
                    Bcloth = reader[6].ToString();
                    string pick = Tcloth + "와 함께 " + Bcloth + "을 입는 것을 추천합니다";
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
            catch
            {
                string pick = "크롭티와 함께 진청바지를 입는 것을 추천합니다(데이터베이스 연결 안됨)";
                extradesign.Text += pick + "\r\n";
            }
        }

        private void outer_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = mysql.Connection();
            string sql;
            if ((-4 <= tem) && (tem <= 0))
            {
                sql = "select * from people_main where -4<=temperature && temperature<=0 limit 1";
            }

            else if ((1 <= tem) && (tem <= 5))
            {
                sql = "select * from people_main where 1<=temperature && temperature <=5 limit 1";
            }

            else if ((6 <= tem) && (tem <= 10))
            {
                sql = "select * from people_main where 6<= temperature && temperature <=10 limit 1";
            }
            else if ((11 <= tem) && (tem <= 15))
            {
                sql = "select * from people_main where 11<= temperature && temperature <=15 limit 1";
            }
            else if ((16 <= tem) && (tem <= 20))
            {
                sql = "select * from people_main where 16<= temperature && temperature <=20 limit 1";
            }
            else if ((21 <= tem) && (tem <= 25))
            {
                sql = "select * from people_main where 21<= temperature && temperature <=25 limit 1";
            }
            else if ((26 <= tem) && (tem <= 30))
            {
                sql = "select * from people_main where 26<=temperature && temperature <=30 limit 1";
            }
            else if ((31 <= tem) && (tem <= 35))
            {
                sql = "select * from people_main where 31<=temperature && temperature <=35 limit 1";
            }
            else if ((36 <= tem) && (tem <= 40))
            {
                sql = "select * from people_main where 36<= temperature && temperature <=40 limit 1";
            }
            else
            {
                sql = " ";
            }
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = new MySqlCommand(sql, connection).ExecuteReader();

                while (reader.Read())
                {
                    Tcloth = reader[4].ToString();
                    Bcloth = reader[6].ToString();
                    Outer = reader[5].ToString();
                    string pick;
                    if (Outer != "")
                        pick = "오늘 날씨에는 " + Outer + "를 입는 것이 좋겠어요";
                    else
                        pick = "아웃터가 없어도 괜찮을 날씨 입니당~!";
                    extradesign.Text += pick + "\r\n";
                }
                reader.Close();
                connection.Close();
            }
            catch
            {
                string pick = "아웃터가 없어도 괜찮을 날씨 입니당~! (데이터베이스 연결 안됨)";
                extradesign.Text += pick + "\r\n";
            }
            
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
            string sql;
            if ((-4 <= tem) && (tem <= 0))
            {
                sql = "select * from people_main where -4<=temperature && temperature<=0 limit 1";
            }

            else if ((1 <= tem) && (tem <= 5))
            {
                sql = "select * from people_main where 1<=temperature && temperature <=5 limit 1";
            }

            else if ((6 <= tem) && (tem <= 10))
            {
                sql = "select * from people_main where 6<= temperature && temperature <=10 limit 1";
            }
            else if ((11 <= tem) && (tem <= 15))
            {
                sql = "select * from people_main where 11<= temperature && temperature <=15 limit 1";
            }
            else if ((16 <= tem) && (tem <= 20))
            {
                sql = "select * from people_main where 16<= temperature && temperature <=20 limit 1";
            }
            else if ((21 <= tem) && (tem <= 25))
            {
                sql = "select * from people_main where 21<= temperature && temperature <=25 limit 1";
            }
            else if ((26 <= tem) && (tem <= 30))
            {
                sql = "select * from people_main where 26<=temperature && temperature <=30 limit 1";
            }
            else if ((31 <= tem) && (tem <= 35))
            {
                sql = "select * from people_main where 31<=temperature && temperature <=35 limit 1";
            }
            else if ((36 <= tem) && (tem <= 40))
            {
                sql = "select * from people_main where 36<= temperature && temperature <=40 limit 1";
            }
            else
            {
                sql = " ";
            }
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = new MySqlCommand(sql, connection).ExecuteReader();

                while (reader.Read())
                {
                    if (Outer == "")
                    {
                        Tcloth = reader[4].ToString();
                        Bcloth = reader[6].ToString();
                        Outer = reader[5].ToString();
                        string c = ".\\cloth\\" + Tcloth + " " + Bcloth + ".jpg";
                        string d = ".\\cloth\\" + Tcloth + " " + Bcloth + "2.jpg";
                        expicture1.Image = Image.FromFile(c);
                        expicture2.Image = Image.FromFile(d);
                    }
                    else
                    {
                        Tcloth = reader[4].ToString();
                        Bcloth = reader[6].ToString();
                        Outer = reader[5].ToString();
                        string c = ".\\cloth\\" + Tcloth + " " + Outer + " " + Bcloth + ".jpg";
                        string d = ".\\cloth\\" + Tcloth + " " + Outer + " " + Bcloth + "2.jpg";
                        expicture1.Image = Image.FromFile(c);
                        expicture2.Image = Image.FromFile(d);
                    }
                }
                reader.Close();
                connection.Close();
            }
            catch
            {
                string c = ".\\cloth\\크롭티 진청바지.jpg";
                string d = ".\\cloth\\크롭티 진청바지2.jpg";
                expicture1.Image = Image.FromFile(c);
                expicture2.Image = Image.FromFile(d);
            }
            
        }

        private void showother_Click(object sender, EventArgs e)
        {

        }

        private void showfashionform3_Load(object sender, EventArgs e)
        {
            string query = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1135056000";

            WebRequest wr = WebRequest.Create(query);
            wr.Method = "GET";

            WebResponse wrs = wr.GetResponse();
            Stream s = wrs.GetResponseStream();
            StreamReader sr = new StreamReader(s);

            string response = sr.ReadToEnd();

            XmlDocument xd = new XmlDocument();
            xd.LoadXml(response);

            XmlNode channel = xd["rss"]["channel"];

            XmlNode xn = xd["rss"]["channel"]["item"]["description"]["body"];

            //textBox에 대입하는 부분
            //textBox1.Text = xn.ChildNodes[0]["hour"].InnerText;

            //날짜 처리를 위한 string
            string m = Convert.ToString(channel["pubDate"].InnerText);
            //날씨
            weather = xn.ChildNodes[1]["wfKor"].InnerText;
            //날짜
            Date = m.Substring(0, 19);
            //평균 온도
            string t = xn.ChildNodes[1]["temp"].InnerText;
            tem = Convert.ToDouble(t);
            //월            
            string Month = m.Substring(6, 2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = mysql.Connection();
            string pick= "";
            if(Tcloth!="" && Bcloth != "")
            {
                if (Outer != "")
                    pick = Tcloth + "과" + Bcloth + "를 입으세요." + Outer + "를 챙기는게 좋겠어요.";
                else
                    pick = Tcloth + "과" + Bcloth + "를 입으세요." + "오늘은 아우터를 챙기지 않아도 괜찮아요.";
            }
            string sql = "insert into login2 (cloth, date, feel) values (\'" + Date + "\',\'" + pick + "\',\'아주 좋아요\')";
            try
            {
                connection.Open();
                try
                {

                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader reader = new MySqlCommand(sql, connection).ExecuteReader();
                    MessageBox.Show("감정을 입력했습니다");
                }
                catch
                {
                    MessageBox.Show("이미 감정을 입력했습니다");

                }
            }
            catch
            {
                MessageBox.Show("데이터베이스가 연결되어 있지 않습니다.");
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = mysql.Connection();
            string pick = "";
            if (Tcloth != "" && Bcloth != "")
            {
                if (Outer != "")
                    pick = Tcloth + "과" + Bcloth + "를 입으세요." + Outer + "를 챙기는게 좋겠어요.";
                else
                    pick = Tcloth + "과" + Bcloth + "를 입으세요." + "오늘은 아우터를 챙기지 않아도 괜찮아요.";
            }
            string sql = "insert into login2 (cloth, date, feel) values (\'" + Date + "\',\'" + pick + "\',\'그저그래요\')";
            try
            {
                connection.Open();
                try
                {

                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader reader = new MySqlCommand(sql, connection).ExecuteReader();
                    MessageBox.Show("감정을 입력했습니다");
                }
                catch
                {
                    MessageBox.Show("이미 감정을 입력했습니다");

                }
            }
            catch
            {
                MessageBox.Show("데이터베이스가 연결되어 있지 않습니다.");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = mysql.Connection();
            string pick = "";
            if (Tcloth != "" && Bcloth != "")
            {
                if (Outer != "")
                    pick = Tcloth + "과" + Bcloth + "를 입으세요." + Outer + "를 챙기는게 좋겠어요.";
                else
                    pick = Tcloth + "과" + Bcloth + "를 입으세요." + "오늘은 아우터를 챙기지 않아도 괜찮아요.";
            }
            string sql = "insert into login2 (cloth, date, feel) values (\'" + Date + "\',\'" + pick + "\',\'별로에요\')";
            try
            {
                connection.Open();
                try
                {

                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader reader = new MySqlCommand(sql, connection).ExecuteReader();
                    MessageBox.Show("감정을 입력했습니다");
                }
                catch
                {
                    MessageBox.Show("이미 감정을 입력했습니다");

                }
            }
            catch
            {
                MessageBox.Show("데이터베이스가 연결되어 있지 않습니다.");
            }
            
        }
    }
}

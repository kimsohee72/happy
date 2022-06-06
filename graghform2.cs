using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;
using System.Windows.Forms.DataVisualization.Charting;

namespace Teamproject1
{
    public partial class graghform2 : Form
    {
        public graghform2()
        {
            InitializeComponent();
        }

        private void graghform_Load(object sender, EventArgs e)
        {
            string query = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1135056000";



            //먼저 클라이언트에서 request 한다!
            WebRequest wr = WebRequest.Create(query);
            wr.Method = "GET";

            //Response를 받는다!
            WebResponse wrs = wr.GetResponse();
            Stream s = wrs.GetResponseStream();
            StreamReader sr = new StreamReader(s);

            string response = sr.ReadToEnd();

            //richTextBox1.Text = response;

            //response 받은 것을 xml 파싱한다!

            XmlDocument xd = new XmlDocument();
            xd.LoadXml(response);

            //제목, 중요한 정보 처리
            XmlNode channel = xd["rss"]["channel"];
            /*label65.Text = channel["title"].InnerText;
            label66.Text = channel["pubDate"].InnerText;*/

            //데이터 처리
            XmlNode xn = xd["rss"]["channel"]["item"]["description"]["body"];

            //원래 차트에 그려져 있던 내용 초기화
            chart1.Series[0].Points.Clear();

            //차트 디자인 설정
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 6;

            //그리드 해제
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

            CustomLabel[] cl = new CustomLabel[9];
            
            double high_t = Convert.ToDouble(xn.ChildNodes[0]["temp"].InnerText);
            double low_t = Convert.ToDouble(xn.ChildNodes[0]["temp"].InnerText);

            for (int i = 0; i < 7; i++)
            {
                double graph_temp = double.Parse(xn.ChildNodes[i]["temp"].InnerText);
                //기온으로 그래프 그리기
                chart1.Series[0].Points.AddXY(i, graph_temp);
                cl[i] = new CustomLabel();
                cl[i].Text = xn.ChildNodes[i]["hour"].InnerText;
                cl[i].FromPosition = i - 1;
                cl[i].ToPosition = i + 1;
                chart1.ChartAreas[0].AxisX.CustomLabels.Add(cl[i]);
               
                //최고, 최저 온도
                double h = Convert.ToDouble(xn.ChildNodes[i]["temp"].InnerText);

                if (h > high_t)
                    high_t = h;

                if (h < low_t)
                    low_t = h;
            }
             //평균 온도
            double avg_t = (high_t+ low_t) / 2;

            weatherinfo.Text = "#평균:" + avg_t + " ";
            weatherinfo.Text += "#최고:" + high_t.ToString() + " ";
            weatherinfo.Text += "#최저:" + low_t.ToString() + " ";
        }

        private void graphformbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform1 mainform2 = new mainform1();
            mainform2.Show();

        }

        private void design1_Click(object sender, EventArgs e)
        {
            this.Hide();
            showfashionform3 showfasion = new showfashionform3();
            showfasion.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Hide();
            showfashionform3 showfasion = new showfashionform3();
            showfasion.Show();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            showfashionform3 showfasionform4 = new showfashionform3();
            showfasionform4.Show();
        }
    }
}


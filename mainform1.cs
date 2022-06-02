using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Teamproject1
{
    public partial class mainform1 : Form
    {
        public mainform1()
        {
            InitializeComponent();
        }

        private void gobutton_Click(object sender, EventArgs e)
        {
            this.Hide();

            graghform2 graphform = new graghform2();
            graphform.Show();

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            this.Hide();

            loginform2 loginform1 = new loginform2();
            loginform1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            showfashionform3 showfashionform1 = new showfashionform3();
            showfashionform1.Show();
        }
    }
}

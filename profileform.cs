using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teamproject1
{
    public partial class profileform : Form
    {
        public profileform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           mainform1 mainform2 = new mainform1();
            mainform2.Show();   

        }
    }
}

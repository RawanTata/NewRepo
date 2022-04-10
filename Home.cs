using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinical
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Patient pat = new Patient();
            pat.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 Cus1 = new Form1();
            Cus1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Medicines Cus1 = new Medicines();
            Cus1.Show();
            this.Hide();
        }
    }
}

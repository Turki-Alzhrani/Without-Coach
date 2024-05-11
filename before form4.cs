using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Without_Coach
{
    public partial class before_form4 : Form
    {
        public before_form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Form4 = new Form4();
            this.Hide();
            Form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("err0r");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("errpr");
        }
    }
}

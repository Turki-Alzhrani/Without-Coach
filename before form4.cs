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
            MessageBox.Show("Please select another item", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select another item", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void before_form4_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class before_mediume_ : Form
    {
        public before_mediume_()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Tables3daysmediume = new Tables_3_days_mediume_();
            this.Hide();
            Tables3daysmediume.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select another item", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select another item", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}

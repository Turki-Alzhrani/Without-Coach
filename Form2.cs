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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                // Open Form2
                Form beforeform3 = new before_form3();
                beforeform3.Show();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                // Open Form1
                Form beforeForm4 = new before_form4();
                this.Hide();
                beforeForm4.Show();
            }
            else if (comboBox2.SelectedIndex == 0 && comboBox1.SelectedIndex == 3)
            {

            }
            else
            {

                MessageBox.Show("Please select another item from the combobox", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox2.Focus();
            }
        }

        private void comboBox2_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox3.Focus();
            }
        }

        private void comboBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();   
            }
        }
    }
}

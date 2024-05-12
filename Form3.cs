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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox7_DropDownStyleChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Format(object sender, ListControlConvertEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox3;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox3;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox3;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox3;
            label4.BackColor = Color.Transparent;
            label23.Parent = pictureBox3;
            label23.BackColor = Color.Transparent;
            label22.Parent = pictureBox3;
            label22.BackColor = Color.Transparent;
            label7.Parent = pictureBox3;
            label7.BackColor = Color.Transparent;
            label8.Parent = pictureBox3;
            label8.BackColor = Color.Transparent;
            label9.Parent = pictureBox3;
            label9.BackColor = Color.Transparent;
            label10.Parent = pictureBox3;
            label10.BackColor = Color.Transparent;
            label11.Parent = pictureBox3;
            label11.BackColor = Color.Transparent;
            label12.Parent = pictureBox3;
            label12.BackColor = Color.Transparent;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (comboBox17.SelectedIndex == 0)
            {
                // Set the link for the first item
                linkLabel1.Text = "Link 1";
                linkLabel1.Tag = "https://youtube.com/shorts/0cXAp6WhSj4?si=TCF-NA1j5bAwJ4X_"; // Set the URL as the Tag property
            }
            else if (comboBox17.SelectedIndex == 1)
            {
                // Set the link for the second item
                linkLabel1.Text = "Link 2";
                linkLabel1.Tag = "https://example.com/link2"; // Set the URL as the Tag property
            }
            else
            {
                // Clear the link label if no item is selected
                linkLabel1.Text = "";

            }
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1.Tag != null && linkLabel1.Tag is string url)
            {
                System.Diagnostics.Process.Start(url);
            }
        }
    }
}

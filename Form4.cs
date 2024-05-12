using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Without_Coach
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
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

            label15.Parent = pictureBox2;
            label15.BackColor = Color.Transparent;





        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox17.SelectedIndex == 0)
            {
                // Set the link for the first item
                linkLabel1.Text = "Barbell Bench Press";
                linkLabel1.Tag = "https://youtube.com/shorts/0cXAp6WhSj4?si=TCF-NA1j5bAwJ4X_"; // Set the URL as the Tag property
            }
            else if (comboBox17.SelectedIndex == 1)
            {
                // Set the link for the second item
                linkLabel1.Text = "Push up";
                linkLabel1.Tag = "https://youtube.com/shorts/yQEx9OC2C3E?si=fkzjZXdPe5cnTIet"; // Set the URL as the Tag property
            }
            else
            {
                // Clear the link label if no item is selected
                linkLabel1.Text = "?";

            }
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {

        if (comboBox16.SelectedIndex == 0)
            {
                // Set the link for the first item
                linkLabel2.Text = "Close-Grip Bench Press";
                linkLabel2.Tag = "https://youtube.com/shorts/43rg7fBNP2w?si=dmpxQ0PEV1BEz0PA"; // Set the URL as the Tag property
            }
            else if (comboBox17.SelectedIndex == 1)
            {
                // Set the link for the second item
                linkLabel2.Text = "Incline Push Up";
                linkLabel2.Tag = "https://youtu.be/vuQnqRGy87Q?si=KJPXBFE0hc8VI2YW"; // Set the URL as the Tag property
            }
            else
{
              // Clear the link label if no item is selected
                linkLabel2.Text = "?";

}
            }
private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox15.SelectedIndex == 0)
            {
                // Set the link for the first item
                linkLabel3.Text = "Standing Military Press";
                linkLabel3.Tag = "https://youtube.com/shorts/DN3WXJlB1Q4?si=BVL7nMX6eItC7qyk"; // Set the URL as the Tag property
            }
            else if (comboBox15.SelectedIndex == 1)
            {
                // Set the link for the second item
                linkLabel3.Text = "Link 2";
                linkLabel3.Tag = "https://example.com/link2"; // Set the URL as the Tag property
            }
            else
            {
                // Clear the link label if no item is selected
                linkLabel3.Text = "?";

            }
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox20.SelectedIndex == 0)
            {
                // Set the link for the first item
                linkLabel4.Text = "Dumbbell Lateral Raise";
                linkLabel4.Tag = "https://youtu.be/vuQnqRGy87Q?si=KJPXBFE0hc8VI2YW"; // Set the URL as the Tag property
            }
            else if (comboBox15.SelectedIndex == 1)
            {
                // Set the link for the second item
                linkLabel4.Text = "Link 2";
                linkLabel4.Tag = "https://example.com/link2"; // Set the URL as the Tag property
            }
            else
            {
                // Clear the link label if no item is selected
                linkLabel4.Text = "?";

            }
        }
    }
}

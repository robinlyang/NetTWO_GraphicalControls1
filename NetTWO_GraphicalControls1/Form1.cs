using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetTWO_GraphicalControls1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copying");
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pasting");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpgs|*.jpg|gifs|*.gifs";
            openFileDialog1.ShowDialog();  //returns a file name
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                box1error.Text = "Need a name";
            }
            else
            {
                box1error.Text = "";
            }
            if (textBox2.Text == "")
            {
                box2error.Text = "Need a phone";
            }
            else
            {
                box2error.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Hey, I need a name");
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
            if(textBox2.Text=="")
            {
                errorProvider1.SetError(textBox2, "Hey, I need a phone");
            }
            else
            {
                errorProvider1.SetError(textBox2, "");
            }
        }
    }
}

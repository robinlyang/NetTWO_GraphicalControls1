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
        public Button b;
        Random r = new Random();
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

        private void button4_Click(object sender, EventArgs e)
        {//define a button in code
            b = new Button();
            b.Text = "Hit me to take a break";
            b.Location = new Point(13, 242);
            b.Click += new System.EventHandler(mybutton_stuff);
            this.Controls.Add(b);
            //turn on timer
            timer1.Enabled = true;
        }
        private void mybutton_stuff(object sender, EventArgs e)
        {
            //turn timer off
            timer1.Enabled = false;
            MessageBox.Show("You Got Me");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            b.Location = new Point(r.Next(1, 300), r.Next(1, 300));
        }
    }
}

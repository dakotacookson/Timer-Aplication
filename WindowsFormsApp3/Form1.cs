using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private int timeset = 0;
        private int textBox1 = 600;

        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (button2.Text != textBox1.ToString())
            {
                progressBar1.Value++;
                timer1.Enabled = true;
                timeset++;
                button2.Text = timeset.ToString();

            }
            if (button2.Text == "59")
            {
                timeset = 99;
            }
            if (button2.Text == "159")
            {
                timeset = 199;
            }
            if (button2.Text == "259")
            {
                timeset = 299;
            }
            if (button2.Text == "359")
            {
                timeset = 399;
            }
            if (button2.Text == "459")
            {
                timeset = 499;
            }
            if (button2.Text == "559")
            {
                button2.Text = "xxxx";
                timer1.Enabled = false;
                MessageBox.Show("Times Up!");

            }

            if (progressBar1.Value == 750)
            {
                progressBar1.Value = 0;
            }
            else if (button2.Text == textBox1.ToString())
            {
                timeset = 0;
                button2.Text = timeset.ToString();
                progressBar1.Value = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timeset = 0;
            progressBar1.Value = 0;
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            timeset = 0;
            button2.Text = timeset.ToString();
            timer1.Enabled = false;
            progressBar1.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
        public static int noOfWorkingDays;
        public static bool[] days = new bool[7];

		public Form1()
		{
			InitializeComponent();
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form5 fb4 = new Form5();
            fb4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            noOfWorkingDays = int.Parse(txt1.Text);
            days[0] = checkBox1.Checked; 
            days[1] = checkBox2.Checked;
            days[2] = checkBox3.Checked;
            days[3] = checkBox4.Checked;
            days[4] = checkBox5.Checked;
            days[5] = checkBox6.Checked;
            days[6] = checkBox7.Checked;

            Form2 f = new Form2();
            f.Show();
            this.Hide();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

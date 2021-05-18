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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txt4.Text = Form1.noOfWorkingDays.ToString();
            checkBox1.Checked = Form1.days[0];
            checkBox2.Checked = Form1.days[1];
            checkBox3.Checked = Form1.days[2];
            checkBox4.Checked = Form1.days[3];
            checkBox5.Checked = Form1.days[4];
            checkBox6.Checked = Form1.days[5];
            checkBox7.Checked = Form1.days[6];

            txt5.Text = Form2.hours.ToString();
            txt6.Text = Form2.mins.ToString();


        }

        private void btn3_Click(object sender, EventArgs e)
        {
            foreach(Control c in Controls)
                if (c is TextBox)
                {
                    c.Text = "";
                 }
            foreach (Control c in Controls)
                if (c is CheckBox)

            {
                CheckBox checkBox = (CheckBox)c;
                checkBox.Checked = false;
            }
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();

        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

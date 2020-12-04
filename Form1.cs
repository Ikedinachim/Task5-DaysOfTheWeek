using System;
using System.Timers;
using System.Globalization;
using System.Windows.Forms;

namespace WeekCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day; int month; int year;

            // Mar = 1 Apr = 2 May = 3 Jun = 4 Jul = 5 Aug = 6 Sep = 7 Oct = 8 Nov = 9 Dec = 10 Jan = 11 Feb = 12
            // day = 1 - 31
            day = Convert.ToInt32(textBox1.Text);
            month = Convert.ToInt32(textBox2.Text);
            year = Convert.ToInt32(textBox3.Text);
          

            DateTime dateValue = new DateTime(year, month, day);




            textBox4.Text = Convert.ToString(dateValue.DayOfWeek);
        }  
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while_loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < 100)
            {
                listBox1.Items.Add(i);
                i = i + 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //odd number total= tek sayı toplamı
            //even number total=çift sayı toplamı
            int i = 1;
            int oddnumbertotal = 0;
            int evennumbertotal = 0;

            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    evennumbertotal += i;
                }
                else
                {
                    oddnumbertotal += i;
                }
                i++;
            }
            MessageBox.Show(String.Format("even number total:{0}\n odd number total:{1}", evennumbertotal, oddnumbertotal));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int year = 2010;

            while (year <= DateTime.Now.Year)
            {
                if (year == 2012 || year == 2014 || year == 2016 || year == 2018 || year == 2020)
                {
                    listBox1.Items.Add(year);
                }
                year++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtexample4.Text);
            int numberdigit = 0;

            while (number > 0)
            {
                numberdigit++;
                number = number / 10;
            }
            MessageBox.Show("entered number is " + numberdigit.ToString() + " digit ");
        }
    }
}

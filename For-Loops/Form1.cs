using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexample1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnexample2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(i);
                }
                else
                {
                    listBox1.Items.Add(i);
                }


            }
        }

        private void btnexample3_Click(object sender, EventArgs e)
        {
            for (char c = 'A'; c <= 'Z'; c++)
                listBox1.Items.Add($"{c}--->{Convert.ToInt32(c)}");
        }

        private void btnexample4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add("pink.com");
            }
        }

        private void btnexample5_Click(object sender, EventArgs e)
        {
            int start = Convert.ToInt32(txtstart.Text);
            int end = Convert.ToInt32(txtend.Text);

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(i.ToString());
                }
            }
        }

        private void btnexample6_Click(object sender, EventArgs e)
        {
            //Arrays
            string[] brands = { "trenyol", "shein", "amazon", "zara" };
            MessageBox.Show(brands[0].ToString());
            for (int i = 0; i < brands.Length; i++)
            {
                listBox1.Items.Add(brands[i]);
            }
        }

        private void btnexample7_Click(object sender, EventArgs e)
        {
            string[] brands = { "bershka", "stradivarius", "beymen", "mavi", "pink" };
            string result = string.Empty;
            bool condition = false;

            for (int i = 0; i < brands.Length; i++)
            {
                if (txtbrand.Text == brands[i])
                {
                    result = brands[i];
                    condition = true;
                    break;

                }
                else
                {
                    continue;
                }
            }
        }

        private void btnexample8_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int[] numbers_1 = new int[10];
            int[] numbers_2 = new int[10];

            for (int i = 0; i < numbers_1.Length; i++)
            {
                numbers_1[i] = random.Next(1, 101);
                numbers_2[i] = random.Next(1, 101);
                listBox1.Items.Add($"{numbers_1[i]}+{numbers_2[i]}={numbers_1[i] + numbers_2[i]}");
            }
        }

        private void btnexample9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is Button)
                {
                    this.Controls[i].BackColor = Color.Pink;
                    this.Controls[i].Width = 100;
                }
                else if (this.Controls[i] is ListBox)
                {
                    this.Controls[i].BackColor = Color.AliceBlue;
                    listBox1.Font = new Font("tahoma", 15);
                }
                else if (this.Controls[i] is TextBox)
                {
                    continue;
                }
            }
        }
    }
}

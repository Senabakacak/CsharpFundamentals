using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreachh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> brands = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string brand in brands)
            {
                listBox1.Items.Add(brand);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            brands.Add(txtbrands.Text);
            foreach (string brand in brands)
            {
                listBox1.Items.Add(brand);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            brands.Add("shein");
            brands.Add("trendyol");
            brands.Add("amazon");
            brands.Add("zara");
            brands.Add("coach");
            brands.Add("mavi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool condition = false;
            foreach (string brand in brands)
            {
                if (brand.ToLower() == txtbrandfind.Text.ToLower())
                {
                    MessageBox.Show("found");
                    condition = true;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (condition == false)
            {
                MessageBox.Show("not found");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control nesne in this.Controls)
            {
                if ((nesne) is TextBox)
                {
                    nesne.BackColor = Color.MediumPurple;
                    nesne.ForeColor = Color.White;
                }
            }
        }
    }
}

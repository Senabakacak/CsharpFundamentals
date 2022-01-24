using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace If_Else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;

            if (Username == "admin" && Password == "1234")
            {
                MessageBox.Show("Login successfull...!");
            }
            else
            {
                MessageBox.Show("Login failed...!");
            }
        }

        private void btnExamCalculate_Click(object sender, EventArgs e)
        {
            double visa = Convert.ToDouble(txtvisaexam.Text);
            double final = Convert.ToDouble(txtfinalexam.Text);

            double avg = (visa * 0.4) + (final * 0.6);
            lblAvg.Text = avg.ToString();

            if (avg < 50 || final < 50)
            {
                lblstatus.Text = "you stayed";
            }
            else
            {
                lblstatus.Text = "you passed";
            }
        }

        private void btnBMIcalculate_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(txtweight.Text);
            double height = Convert.ToDouble(txtheight.Text);

            double index = weight / (height * height);

            lblindex.Text = index.ToString();

            if (index < 18)
            {
                label10.Text = "weak";
            }
            else if (index >= 18 && index < 25)
            {
                label10.Text = "Normal";
            }
            else if (index >= 25 && index < 30)
            {
                label10.Text = "fat";
            }
            else if (index >= 30 && index < 35)
            {
                label10.Text = "Obese";
            }
            else
            {
                label10.Text = "seriously Obese";
            }

        }
    }
}

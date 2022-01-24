using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int number_1;
        int number_2;

        //I created a simple calculator
        private void btnAddition_Click(object sender, EventArgs e)
        {
            int number_1 = Convert.ToInt32(txtNum1.Text);
            int number_2 = Convert.ToInt32(txtNum2.Text);

            int Addition = number_1 + number_2;

            lblConclusion.Text = Addition.ToString();
        }

        private void btnExtraction_Click(object sender, EventArgs e)
        {
            int number_1 = Convert.ToInt32(txtNum1.Text);
            int number_2 = Convert.ToInt32(txtNum2.Text);

            int Extraction = number_1 - number_2;

            lblConclusion.Text = Extraction.ToString();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            int number_1 = Convert.ToInt32(txtNum1.Text);
            int number_2 = Convert.ToInt32(txtNum2.Text);

            int Multiplication = number_1 * number_2;

            lblConclusion.Text = Multiplication.ToString();
        }

        private void btnDivison_Click(object sender, EventArgs e)
        {
            int number_1 = Convert.ToInt32(txtNum1.Text);
            int number_2 = Convert.ToInt32(txtNum2.Text);

            int Division = number_1 / number_2;

            lblConclusion.Text = Division.ToString();
        }
    }
}

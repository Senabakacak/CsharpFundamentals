using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathFunctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Pi Sayısı: {Math.PI}");
        }

        private void btnABS_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Math.Abs(-15.5).ToString());
        }

        private void btnFloor_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Floor: {Math.Floor(Double.Parse(txtVeri.Text))}");
        }

        private void btnCeiling_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Ceiling: {Math.Ceiling(Decimal.Parse(txtVeri.Text))}");
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Round: {Math.Round(Double.Parse(txtVeri.Text))}");

        }

        private void btnTruncate_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Truncate: {Math.Truncate(decimal.Parse(txtVeri.Text))}");
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Pow: {Math.Pow(3, Math.Pow(int.Parse(txtVeri.Text), 2))}");
        }

        private void btnSQRT_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"SQRT: {Math.Sqrt(double.Parse(txtVeri.Text))}");
        }
    }
}

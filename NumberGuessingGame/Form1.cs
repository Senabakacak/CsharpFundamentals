using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double number;
        int score;
        private void btnstart_Click(object sender, EventArgs e)
        {
            score = 100;
            lblscore.Text = "Score : " + score.ToString();

            btnguessnumber.Enabled = true;

            Random random = new Random();
            number = random.Next(101);

            MessageBox.Show("I kept a number in my mind...");
        }

        private void btnguessnumber_Click(object sender, EventArgs e)
        {
            int guessing = Convert.ToInt32(txtguessnumber.Text);

            if (guessing < number)
            {
                MessageBox.Show("UP");
                score = score - 5;
            }
            else if (guessing > number)
            {
                MessageBox.Show("DOWN");
                score = score - 5;
            }
            else
            {
                MessageBox.Show("TRUE!");

            }
            if (score == 0)
            {
                MessageBox.Show("GAME OVER!");
                btnguessnumber.Enabled = false;
            }
            lblscore.Text = "SCORE : " + score.ToString();
            txtguessnumber.Clear();

        }
    }
}

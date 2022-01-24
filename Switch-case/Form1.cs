using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUserlogin_Click(object sender, EventArgs e)
        {
            string title = txtusername.Text;
            string message = string.Empty;

            switch (title)
            {
                case "teacher":
                case "manager":
                    message = "You are being redirected to the admin panel";
                    break;
                case "student":
                    message = "You are being redirected to the student panel";
                    break;
                default:
                    message = "User login is incorrect";
                    break;

            }
            MessageBox.Show(message);
        }

        private void btncevir_Click(object sender, EventArgs e)
        {
            //ceviri=translate,gunler=days

            string message;

            switch (txtgunler.Text.ToLower())
            {
                case "pazartesi":
                    message = "monday";
                    break;
                case "salı":
                    message = "tuesday";
                    break;
                case "çarşamba":
                    message = "wednesday";
                    break;
                case "perşembe":
                    message = "thursday";
                    break;
                case "cuma":
                    message = "friday";
                    break;
                case "cumartesi":
                    message = "saturday";
                    break;
                case "pazar":
                    message = "sunday";
                    break;
                default:
                    message = "böyle bir gün yok";
                    break;

            }
            MessageBox.Show(message);
        }

        private void btn_days_Click(object sender, EventArgs e)
        {
            string message;

            switch (txtdays.Text.ToLower())
            {
                case "weekend":
                    message = "monday,tuesday,wednesday,thursday,friday";
                    break;
                case "weekday":
                    message = "saturday,sunday";
                    break;
                default:
                    message = "not found";
                    break;

            }
            MessageBox.Show(message);
        }
    }
}

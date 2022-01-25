using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomFunctions
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string GeneratedCaptcha()
        {
            string captcha = Guid.NewGuid().ToString();
            string[] splitedcaptcha = captcha.Split('-');
            return splitedcaptcha[1].ToString();

        }

        bool Eraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = String.Empty;
                }

            }
            return true;
        }


        Dictionary<string, string> users = new
        Dictionary<string, string>();

        bool SignUp(string username, string password)
        {
            if (username == " " && password == " ")
            {
                return false;
            }
            else
            {
                users.Add(username, password);
                return true;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            lblcaptcha.Text = GeneratedCaptcha();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            bool result = SignUp(txtusername.Text, txtpassword.Text);

            if(result==true)
            {
                groupBox2.Visible = true;
                Eraser(groupBox1);
            }
            else
            {
                MessageBox.Show("lütfen bilgilerinizi giriniz..");
            }
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            for(int i=0;i<users.Count;i++)
            {
                MessageBox.Show($"user name:{users.ElementAt(i).Key}\n password: {users.ElementAt(i).Value}");
            }
        }
    }
    
}


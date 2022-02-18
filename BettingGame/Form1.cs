using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BettingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, int> users= new Dictionary<string, int>();

        public static int safe;
        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Günlük chip kazanmak istermisiniz..!", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                btnDailyChip.Visible = true;
            }

        }

        private void btnDailyChip_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int dailyChip=random.Next(500,1001);
            safe = dailyChip + 1000;
            MessageBox.Show($"Kazanilan chip:{dailyChip}\nKasa:{safe}");
            users.Add("beast",safe);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(users.Keys.ElementAt(0)==txtusername.Text && txtpassword.Text=="123")
            {
                Form2 frm = new Form2();
                frm.Show();
            }
        }
    }
}

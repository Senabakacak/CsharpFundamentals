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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int TahminEdilicekSayi = 0;
        int Kasa = Form1.safe;
        private void Form2_Load(object sender, EventArgs e)
        {
            Random rdn = new Random();
            TahminEdilicekSayi = rdn.Next(1, 101);
            lblBackDoor.Text = TahminEdilicekSayi.ToString();
            lblKasa.Text = Kasa.ToString();
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            if(Kasa>0)
            {
                int bahisMiktari = int.Parse(txtBahis.Text);
                int kullanicitahmini = int.Parse(txtTahmin.Text);

                if(TahminEdilicekSayi==kullanicitahmini)
                {
                    Kasa += bahisMiktari * 2;
                    lblKasa.Text = Kasa.ToString();
                    btnOyna.Enabled= false;
                    txtBahis.Text = " ";
                    txtTahmin.Text = " ";
                    DialogResult dr = MessageBox.Show("Oynamak ister misin?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        btnOyna.Enabled = true;
                    }
                    else
                    {
                        this.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show("Kasada para kalmadı!");
            }
        }
    }
}

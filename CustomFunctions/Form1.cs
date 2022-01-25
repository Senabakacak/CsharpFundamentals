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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Example1
        ///<summary>
        ///</summary>
        ///<param name="value_1"></param>
        ///<param name="value_2"></param>
        ///<returns></returns>

        int ToplamaYap(int value_1, int value_2)
        {
            int toplam = value_1 + value_2;
            return toplam;
        }
        private void btnexample1_Click(object sender, EventArgs e)
        {
            int sayi_1 = Convert.ToInt32(txtVeri1.Text);
            int sayi_2 = Convert.ToInt32(txtVeri2.Text);

            MessageBox.Show($"sonuç:{ToplamaYap(sayi_1, sayi_2)}");
        }
        #endregion

        #region Examples 2
        string TekCiftSayilarinToplami ()
        {
            int ciftlerintoplami = 0;
            int teklerintoplami = 0;
            for(int i=0;i<=100;i++)
            {
                if(i%2==0)
                {
                    ciftlerintoplami += i;
                }
                else
                {
                    teklerintoplami += i;
                }
            }
            return String.Format("Çiftlerin toplamı: {0}\nTeklerin toplamı: {1}", ciftlerintoplami, teklerintoplami);
        }

        private void btnexample2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TekCiftSayilarinToplami());
        }
        #endregion

        #region Example 3

        string mailcreator (string fullname)
        {
            return $" { fullname.ToLower().Replace(' ', '.')} @gmaill.com";
        }
        private void btnexample3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mailcreator(txtVeri1.Text));
        }
        #endregion

        #region Example 4
        object cmbRenk (ComboBox comboBox)
        {
            return comboBox.SelectedItem;
        }

        private void btnexample4_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is Button && item.Text == "Example 4")
                {
                    item.BackColor = ColorTranslator.FromHtml(cmbRenk(cmbRenkler).ToString());
                }
            }
        }
        #endregion
    }

}


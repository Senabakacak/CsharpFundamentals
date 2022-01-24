using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringFunctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompareTo_Click(object sender, EventArgs e)
        {
            string sampletext = txtVeriGirisi1.Text;
            int result = sampletext.CompareTo(txtVeriGirisi2.Text);

            string message = String.Empty;

            switch (result)
            {
                case -1:
                    message = "Kelime diğer kelime işle eşleşmedi fazla karakter var..!";
                    break;
                case 0:
                    message = "Kelimeler eşleşti..!";
                    break;
                case 1:
                    message = "Kelime diğer kelime ile eşleşmemektedir. Eksik karekter var..!";
                    break;
                default:
                    break;
            }

            MessageBox.Show(message);
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            string sampletext = txtVeriGirisi1.Text;
            bool result = sampletext.Contains(txtVeriGirisi2.Text);


            
            if (result == true)
            {
                MessageBox.Show("İçermektedir..!");
            }
            else
            {
                MessageBox.Show("İçermemektedir..!");
            }
        }

        private void btnStartWith_Click(object sender, EventArgs e)
        {
            string sampletext = txtVeriGirisi1.Text;
            bool result = sampletext.StartsWith(txtVeriGirisi2.Text);

            if (result == true)
                MessageBox.Show("Başlamaktadır..!");
            else
                MessageBox.Show("Başlamamaktadır..!");
        }

        private void btnEndsWith_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtVeriGirisi1.Text.EndsWith(txtVeriGirisi2.Text) ? "Bitmektedir..!" : "Bitmemektedir");

        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtVeriGirisi1.Text.IndexOf(txtVeriGirisi2.Text).ToString());
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtVeriGirisi1.Text.LastIndexOf(txtVeriGirisi2.Text).ToString());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtVeriGirisi1.Text.Remove(2, 5));
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtVeriGirisi1.Text.Replace("man", "woman"));
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            string mailAddress = txtVeriGirisi1.Text;
            string[] mailAdresses = mailAddress.Split(';');

            foreach (string mail in mailAdresses)
            {
            
                listBox1.Items.Add(mail.Remove(mail.IndexOf('@')).Replace('.', ' '));
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sampletext = txtVeriGirisi1.Text;
            string result = sampletext.Insert(5, "cik");
            MessageBox.Show(result);
        }

        private void btnSubString_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtVeriGirisi1.Text.Substring(3, 2));
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Boşluklarla birlikte Hesplanan Karakter Sayısı: {txtVeriGirisi1.Text.Length}\n Boşluklar Silindikten Sonraki Karakter Sayısı: {txtVeriGirisi1.Text.Trim().Length}");
        }

        private void btnToUpper_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtVeriGirisi1.Text.ToUpper());
        }

        private void btnToLower_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtVeriGirisi1.Text.ToLower());
        }
    }
}

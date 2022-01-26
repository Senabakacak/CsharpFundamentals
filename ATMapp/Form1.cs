using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string captchaolustur() //benzersiz captcha olusturduk
        {
            string captcha = Guid.NewGuid().ToString();
            string[] splitedcaptcha = captcha.Split('-');
            return splitedcaptcha[1].ToString();

        }

   
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false; 
            lblcaptcha.Text = captchaolustur();
        }


        private void btngirisyap_Click(object sender, EventArgs e) //kayıtlı kullanıcı girisi
        {
            string tcno = txttcno.Text;
            string sifre = txtsifre.Text;
            string message = string.Empty;
            groupBox2.Visible = true;
          
            switch (tcno)
            {
                case "123456":

                    switch (sifre)
                    {
                        case "1234":
                            message = "yönlendiriliyorsunuz..";
                            
                            break;
                        default:
                            message = "şifreniz hatalı..";
                            break;
                    }
                    break;
                default:
                    message = "tcno hatalı..";
                    break;
            }
            MessageBox.Show(message);

        }




        int bakiye = 100000;

        private void btnbakiyegoruntule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem algılandı, bakiye görüntüleniyor...");
            MessageBox.Show("Bakiyeniz: " + bakiye);

          
        }


        private void btnparacek_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem algılandı, para çekme işlemi başlıyor...");
            MessageBox.Show("Lütfen çekilecek tutarı girin");

            string cekilecek_tutar = Convert.ToString(txtverigirisi.Text);
            int cekilecek_tutar_int = Convert.ToInt32(txtverigirisi.Text);

            if (cekilecek_tutar_int <= bakiye)
            {
                MessageBox.Show("Para çekme işlemi kabul edildi para çekiliyor..");
                MessageBox.Show("Para çekildi yeni bakiyeniz: " + (bakiye - cekilecek_tutar_int));
                
            }
            else
            {
                MessageBox.Show("Bu miktarda para çekmek için bakiyeniz yetersiz.");
                
            }
        }


        private void btnparayatır_Click(object sender, EventArgs e)
        {
           MessageBox.Show("İşlem algılandı, para yatırma işlemi başlıyor...");
           MessageBox.Show("Lütfen yatıralacak tutarı girin"); 

            string yatiralacak_tutar = Convert.ToString(txtverigirisi.Text);
            int yatiralacak_tutar_int = Convert.ToInt32(txtverigirisi.Text);

            MessageBox.Show("Yatıralacak tutar algılandı");

            MessageBox.Show("Para yatırma işlemi başarıyla tamamlandı yeni bakiyeniz: " + (bakiye + yatiralacak_tutar_int));
          
        }

       
      


    }
}

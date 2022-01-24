using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DowhileLoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExample1_Click(object sender, EventArgs e)
        {
            int i = 1;
            do
            {
                listBox1.Items.Add(i);
                i++;
            } while (i > 100);
        }

        private void btnExample2_Click(object sender, EventArgs e)
        {
            //1-250 arasındaki çift ve tek sayıların toplamının karesini bulun
            // Find the square of the sum of the even and odd numbers from /1-250
            //odd number total= tek sayı toplamı
            //even number total=çift sayı toplamı
            int i = 0;
            int oddnumbertotal = 0;
            int evennumbertotal = 0;

            do
            {
                if (i % 2 == 0)
                {
                    evennumbertotal += i;
                }
                else
                {
                    oddnumbertotal += i;
                }
                i++;
            } while (i <= 250);
            int result = (evennumbertotal + oddnumbertotal) * (evennumbertotal + oddnumbertotal);
            listBox1.Items.Add($"even number total:{evennumbertotal}");
            listBox1.Items.Add($"odd number total:{oddnumbertotal}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplam, fark, carpım, bolum;
            sayi1=Convert.ToDouble(txtSayi1.Text);
            sayi2=Convert.ToDouble(txtSayi2.Text);

            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpım = sayi1 * sayi2;
            bolum = sayi1 / sayi2;

            lblToplam.Text = "Toplam: " + toplam;
            lblFark.Text = "Fark: " + fark;
            lblCarpım.Text = "Carpım: " + carpım;
            lblBolme.Text = "Bolme: " + bolum;
        }
    }
}

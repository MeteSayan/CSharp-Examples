using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2;
            double toplam, fark, bolum, carpim,us;

            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);

            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpim = sayi1 * sayi2;
            bolum = sayi1 / sayi2;
            us = Math.Pow(sayi1, sayi2);

            Lbltoplam.Text = toplam.ToString();
            lblFark.Text = fark.ToString();
            lblCarpim.Text = carpim.ToString();
            lblBolum.Text = bolum.ToString();
            lblUs.Text = us.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi3;
            double karekok;

            sayi3 = Convert.ToDouble(textBox3.Text);
            karekok = Math.Sqrt(sayi3);

            lblkarekok.Text = karekok.ToString();
        }
    }
}

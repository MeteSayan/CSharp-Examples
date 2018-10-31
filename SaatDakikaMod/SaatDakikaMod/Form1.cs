using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaatDakikaMod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            int saat, dakika;

            sayi = Convert.ToInt32(textBox1.Text);

            saat = sayi / 60;
            label3.Text = Convert.ToString(saat);

            dakika = sayi % 60;
            label5.Text = Convert.ToString(dakika);
        }
    }
}

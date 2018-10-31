using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi1 = 20, sayi2 = 5, sonuc;
       

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sonuc = sayi1 + sayi2;
            label1.Text = Convert.ToString(sonuc);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sonuc = sayi1 - sayi2;
            label1.Text = Convert.ToString(sonuc);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            sonuc = sayi1 * sayi2;
            label1.Text = Convert.ToString(sonuc);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            sonuc = sayi1 / sayi2;
            label1.Text = Convert.ToString(sonuc);
        }
    }
}

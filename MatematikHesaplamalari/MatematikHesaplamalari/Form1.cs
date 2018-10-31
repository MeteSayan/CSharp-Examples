using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatematikHesaplamalari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int birkenar;
            int alan, cevre;
          
            birkenar = Convert.ToInt32(textBox1.Text);
         
            alan = birkenar * birkenar;
            cevre = 4 * birkenar;

            label5.Text = alan.ToString();
            label6.Text = cevre.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label7.Visible = false;
            textBox2.Visible = false;
            label1.Text = "Kare";
            button3.Visible = false;
            button4.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Text = "Dikdörtgen";
            label3.Text = "Kısa kenar";
            button4.Visible = false;
            label3.Text = "Kısa kenar";
            label7.Visible = true;
            textBox2.Visible = true;
            button3.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int dikalan, dikcevre,kisa;
            int uzun;
            uzun = Convert.ToInt32(textBox2.Text);
            kisa = Convert.ToInt32(textBox1.Text);

            dikalan = kisa * uzun;
            dikcevre = (2 * kisa) + (2 * uzun);

            label5.Text = dikalan.ToString();
            label6.Text = dikcevre.ToString();
        }
    }
}

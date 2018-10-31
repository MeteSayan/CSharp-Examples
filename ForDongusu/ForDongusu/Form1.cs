using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForDongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;
        int toplam = 0;
        int faktoriyel = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            
            for(i = 0; i < 10; i++)
            {
                toplam += i;
                label1.Text = toplam.ToString();
                listBox1.Items.Add(toplam);
                
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(i=1; i < 7; i++)
            {
                faktoriyel *= i;
                label2.Text = faktoriyel.ToString();
                listBox2.Items.Add(faktoriyel);

            }
        }
    }
}

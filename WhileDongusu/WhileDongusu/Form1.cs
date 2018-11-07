using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileDongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;

            while(i < 10)
            {
                listBox1.Items.Add(i);
                i++;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int j = 0;

           
            do{
                listBox2.Items.Add(j);
                j++;
            } while (j < 20) ;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x;

            for (x = 0; x < 15; x++)
            {
                listBox3.Items.Add(x);
            } 

        }
    }
}

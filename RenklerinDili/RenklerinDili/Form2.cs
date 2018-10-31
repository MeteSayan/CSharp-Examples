using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenklerinDili
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Mavi")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " rengi : " + "mutluluğun ve pozitifliğin rengidir.";
                button2.BackColor = Color.Blue;
            }
            if(comboBox1.Text == "Sarı")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " rengi : " + "iyimserliğin rengidir.";
                button2.BackColor = Color.Yellow;
            }
            if (comboBox1.Text == "Kırmızı")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " rengi : " + "tutkunun rengidir.";
                button2.BackColor = Color.Red;
            }
            if (comboBox1.Text == "Siyah")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " rengi : " + "karamsarlığın rengidir.";
                button2.BackColor = Color.Black;
            }
            if (comboBox1.Text == "Beyaz")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " rengi : " + "saflığın ve yeni başlangıçların rengidir.";
                button2.BackColor = Color.White;
            }
            if (comboBox1.Text == "Yeşil")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " rengi : " + "bereketin rengidir.";
                button2.BackColor = Color.Green;
            }

        }
    }
}

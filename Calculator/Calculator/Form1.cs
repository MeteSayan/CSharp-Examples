using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int result;

            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);

            result = number1 + number2;

            label4.Text = result.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int result;

            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);

            result = number1 - number2;

            label4.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int result;

            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);

            result = number1 / number2;

            label4.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int result;

            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);

            result = number1 * number2;

            label4.Text = result.ToString();
        }
    }
}

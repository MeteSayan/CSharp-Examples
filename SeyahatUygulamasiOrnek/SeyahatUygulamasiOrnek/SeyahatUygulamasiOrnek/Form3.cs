using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeyahatUygulamasiOrnek
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 bilet = new Form2();
            bilet.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://scserv.nrgplay.com/stream/102/";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://rockfm.rockfm.com.tr:9450/;stream.ogg";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://yayin.damarfm.com:8080/;";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            webBrowser1.Navigate("http://www.mgm.gov.tr/sunum/tahmin-show-2.aspx?m=ANKARA&basla=1&bitir=5&rC=111&rZ=fff");
        }
    }
}

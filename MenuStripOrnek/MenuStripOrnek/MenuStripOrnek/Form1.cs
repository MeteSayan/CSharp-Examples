using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStripOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void esaretinBedeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Esaretin Bedeli, Andy ve Red isimli iki mahkumun parmaklıklar ardında kurdukları dünyanın hikayesini anlatıyor. Andy Dufresne, genç ve başarılı bir bankerdir. Karısını ve karısının sevgilisini öldürmek suçundan yargılanır ve ömür boyu hapis cezası alır. Shawsank Hapishanesi'nde dayak, işkence, tecavüz, her türlü durum yaşanmaktadır fakat Andy gene de hayata bağlı ve iyimserdir. Bu tutumu etrafındakileri de etkiler. Andy umutlu bakış açısıyla çevresindeki tüm mahkumları, parmaklıklar arkasında bile özgür bir yaşam olabileceğine inandırır. Andy'nin bu çabalarına ortak olacak bir arkadaşı da olacaktır: Red.Bir Stephen King uyarlaması olan filmde Morgan Freeman ve Tim Robbins başrolde. Film, 1995'te, aralarında en iyi film adaylığı da olmak üzere tam 7 dalda Oscar'a aday gösterildi.";
            listBox1.Items.Add("Esaretin Bedeli");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void amelieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Amelie, Ünlü Fransız yönetmen Jean-Pierre Jeunet’nin beş dalda Oscar’a aday gösterilen ve son on yılın en ses getiren yapımları arasında. Bu Fransız komedisi bizi genç ve özel bir kadınla tanışmaya davet ediyor; her daim hayat dolu, yaşama sevgi dolu gözlerle tanıklık eden ve sahip olduğu özel ışıltıyı her anında yanında taşıyan Amelie’nin hikayesine... Anne ve babasını kaybetmiş olan Amelie, kendini başkalarının hayatlarını tamir etmeye, onları mutlu kılmaya adamıştır; bu adanmışlığı fark ettirmeden, bu durumdan bihaber olan insanların hayatlarını kolaylaştırmaya yönelik yapmaktadır. Peki başkalarının mutluluğu için çabalayan Amelie, yalnızlığının farkına vardığı an kendi mutluluğu için de çabalamaya başlayacak mıdır?";
            listBox1.Items.Add("Amelie");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void yüzüklerinEfendisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Yüzüklerin Efendisi: Yüzük Kardeşliği, dünyanın kaderini değişterecek olan yüzükten kurtulmak için verilen mücadeleyi konu ediyor. Yıllar önce üretilen ve Orta Dünya topraklarına kandan başka hiçbir şey getirmeyen yüzüklerin sonuncusu, üretiminden yüz yıllar sonra ortaya çıkar. Amcasının kendisine emanet ettiği yüzüğün nelere kadir olduğundan habersiz olan Frodo, büyücü Gandalf'ın anlattıkları sonrasında dehşete kapılır. Bu yüzükten ve müstakbel savaşlardan kurtulmanın tek yolu, gücünü toplamaya çalışan Sauron'u da engellemek için bu yüzüğü yok etmektir. Yüzüğü yok edilebileceği tek yer olan Mordor'a götürmek için kendini feda eden savaşçılardan oluşan bir ekip oluşturulur. Çok uzun ve çetin geçecek olan yolculuk başlar. Orta Dünya'nın kaderi, bu insanların ellerindedir.";
            listBox1.Items.Add("Yüzüklerin Efendisi");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void felektenBirGeceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Sıradışı bir mizah anlayışına sahip Hangover, bilindik Hollywood mizah klişelerine yaslanmayan, gayet eğlenceli bir yapım. Filmde arkadaşlarının düğününden iki gün önce bekârlığa veda partisi vermek için Las Vegas’a giden dört tuhaf arkadaşın, sarhoş oldukları parti gecesinin sabahında odalarında bir kaplan, tavuklar ve dolapta ağlayan altı aylık bir bebek ile uyanmaları üzerine gelişen olağanüstü maceralar aktarılmaktadır. Damadın ortalıkta olmaması da ayrı bir meseledir! Kafaları hala kıyak olan bu kafadarlar, bir gece öncesine dair hiçbirşeyi hatırlayamazlar. Birbirinden şapşal ama sevimli bu üç hergele, ipuçlarını takip ederek işlerin nerede kontrolden çıktığını bulmak zorundadırlar. En önemlisi de damadı bularak zamanında Los Angeles’a düğününe yetiştirmeleri gerekmektedir.";
            listBox1.Items.Add("Felekten Bir Gece");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }
    }
}

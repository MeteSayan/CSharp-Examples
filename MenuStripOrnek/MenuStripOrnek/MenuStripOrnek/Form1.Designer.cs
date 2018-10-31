namespace MenuStripOrnek
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aksiyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romantikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maceraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esaretinBedeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amelieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yüzüklerinEfendisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.komediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felektenBirGeceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.puanVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aksiyonToolStripMenuItem,
            this.romantikToolStripMenuItem,
            this.maceraToolStripMenuItem,
            this.komediToolStripMenuItem,
            this.puanVerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aksiyonToolStripMenuItem
            // 
            this.aksiyonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.esaretinBedeliToolStripMenuItem,
            this.toolStripSeparator2});
            this.aksiyonToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.aksiyonToolStripMenuItem.Name = "aksiyonToolStripMenuItem";
            this.aksiyonToolStripMenuItem.Size = new System.Drawing.Size(72, 32);
            this.aksiyonToolStripMenuItem.Text = "Dram";
            // 
            // romantikToolStripMenuItem
            // 
            this.romantikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.amelieToolStripMenuItem,
            this.toolStripSeparator4});
            this.romantikToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.romantikToolStripMenuItem.Name = "romantikToolStripMenuItem";
            this.romantikToolStripMenuItem.Size = new System.Drawing.Size(107, 32);
            this.romantikToolStripMenuItem.Text = "Romantik";
            // 
            // maceraToolStripMenuItem
            // 
            this.maceraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.yüzüklerinEfendisiToolStripMenuItem,
            this.toolStripSeparator5});
            this.maceraToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.maceraToolStripMenuItem.Name = "maceraToolStripMenuItem";
            this.maceraToolStripMenuItem.Size = new System.Drawing.Size(88, 32);
            this.maceraToolStripMenuItem.Text = "Macera";
            // 
            // esaretinBedeliToolStripMenuItem
            // 
            this.esaretinBedeliToolStripMenuItem.Name = "esaretinBedeliToolStripMenuItem";
            this.esaretinBedeliToolStripMenuItem.Size = new System.Drawing.Size(216, 32);
            this.esaretinBedeliToolStripMenuItem.Text = "Esaretin Bedeli";
            this.esaretinBedeliToolStripMenuItem.Click += new System.EventHandler(this.esaretinBedeliToolStripMenuItem_Click);
            // 
            // amelieToolStripMenuItem
            // 
            this.amelieToolStripMenuItem.Name = "amelieToolStripMenuItem";
            this.amelieToolStripMenuItem.Size = new System.Drawing.Size(216, 32);
            this.amelieToolStripMenuItem.Text = "Amelie";
            this.amelieToolStripMenuItem.Click += new System.EventHandler(this.amelieToolStripMenuItem_Click);
            // 
            // yüzüklerinEfendisiToolStripMenuItem
            // 
            this.yüzüklerinEfendisiToolStripMenuItem.Name = "yüzüklerinEfendisiToolStripMenuItem";
            this.yüzüklerinEfendisiToolStripMenuItem.Size = new System.Drawing.Size(252, 32);
            this.yüzüklerinEfendisiToolStripMenuItem.Text = "Yüzüklerin Efendisi";
            this.yüzüklerinEfendisiToolStripMenuItem.Click += new System.EventHandler(this.yüzüklerinEfendisiToolStripMenuItem_Click);
            // 
            // komediToolStripMenuItem
            // 
            this.komediToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator7,
            this.felektenBirGeceToolStripMenuItem,
            this.toolStripSeparator8});
            this.komediToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.komediToolStripMenuItem.Name = "komediToolStripMenuItem";
            this.komediToolStripMenuItem.Size = new System.Drawing.Size(92, 32);
            this.komediToolStripMenuItem.Text = "Komedi";
            // 
            // felektenBirGeceToolStripMenuItem
            // 
            this.felektenBirGeceToolStripMenuItem.Name = "felektenBirGeceToolStripMenuItem";
            this.felektenBirGeceToolStripMenuItem.Size = new System.Drawing.Size(239, 32);
            this.felektenBirGeceToolStripMenuItem.Text = "Felekten Bir Gece";
            this.felektenBirGeceToolStripMenuItem.Click += new System.EventHandler(this.felektenBirGeceToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(213, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(213, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(249, 6);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(249, 6);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(236, 6);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(236, 6);
            // 
            // puanVerToolStripMenuItem
            // 
            this.puanVerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.puanVerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.puanVerToolStripMenuItem.Name = "puanVerToolStripMenuItem";
            this.puanVerToolStripMenuItem.Size = new System.Drawing.Size(100, 32);
            this.puanVerToolStripMenuItem.Text = "Puan Ver";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 36);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 149);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(551, 433);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(700, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Film :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(655, 193);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 116);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(655, 368);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(175, 116);
            this.listBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(650, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Verdiğiniz Puan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Konu:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(923, 581);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aksiyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem esaretinBedeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem romantikToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem amelieToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem maceraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem yüzüklerinEfendisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem komediToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem felektenBirGeceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem puanVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


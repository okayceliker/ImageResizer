namespace ResimBoyutlandırma
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_Resimler = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listBox_ResimDizini = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_onceki = new System.Windows.Forms.Button();
            this.button_sonraki = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Show = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip9 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip12 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip13 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip10 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip14 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResimAcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boyutlandırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arkaplanRengiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Resimler)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_Resimler
            // 
            this.pictureBox_Resimler.BackColor = System.Drawing.Color.Gray;
            this.pictureBox_Resimler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Resimler.Location = new System.Drawing.Point(302, 50);
            this.pictureBox_Resimler.Name = "pictureBox_Resimler";
            this.pictureBox_Resimler.Size = new System.Drawing.Size(717, 524);
            this.pictureBox_Resimler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Resimler.TabIndex = 0;
            this.pictureBox_Resimler.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox_Resimler, "Resimler burada gösterilir.");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox_ResimDizini
            // 
            this.listBox_ResimDizini.FormattingEnabled = true;
            this.listBox_ResimDizini.Location = new System.Drawing.Point(14, 45);
            this.listBox_ResimDizini.Name = "listBox_ResimDizini";
            this.listBox_ResimDizini.ScrollAlwaysVisible = true;
            this.listBox_ResimDizini.Size = new System.Drawing.Size(282, 433);
            this.listBox_ResimDizini.TabIndex = 9;
            this.toolTip4.SetToolTip(this.listBox_ResimDizini, "Seçtiğiniz klasördeki resimlerin nerede bulunduğunu belirtir.");
            this.listBox_ResimDizini.SelectedIndexChanged += new System.EventHandler(this.ListBox_ResimDizini_SelectedIndexChanged);
            // 
            // button_onceki
            // 
            this.button_onceki.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_onceki.Location = new System.Drawing.Point(6, 19);
            this.button_onceki.Name = "button_onceki";
            this.button_onceki.Size = new System.Drawing.Size(75, 32);
            this.button_onceki.TabIndex = 12;
            this.button_onceki.Text = "Önceki <";
            this.toolTip9.SetToolTip(this.button_onceki, "Önceki resime geçiş yapar.");
            this.button_onceki.UseVisualStyleBackColor = true;
            this.button_onceki.Click += new System.EventHandler(this.button_onceki_Click);
            // 
            // button_sonraki
            // 
            this.button_sonraki.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sonraki.Location = new System.Drawing.Point(85, 19);
            this.button_sonraki.Name = "button_sonraki";
            this.button_sonraki.Size = new System.Drawing.Size(75, 32);
            this.button_sonraki.TabIndex = 13;
            this.button_sonraki.Text = "Sonraki >";
            this.toolTip10.SetToolTip(this.button_sonraki, "Sonraki resime geçiş yapar.");
            this.button_sonraki.UseVisualStyleBackColor = true;
            this.button_sonraki.Click += new System.EventHandler(this.button_sonraki_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(302, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Şuan da Görüntülenen Resim Yok.";
            // 
            // button_Show
            // 
            this.button_Show.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Show.Location = new System.Drawing.Point(6, 103);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(156, 29);
            this.button_Show.TabIndex = 15;
            this.button_Show.Text = "Slide Show Başlat";
            this.toolTip8.SetToolTip(this.button_Show, "Seçtiğimiz saniye kadar resimlerin geçişini sağlar.");
            this.button_Show.UseVisualStyleBackColor = true;
            this.button_Show.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(6, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 24);
            this.comboBox1.TabIndex = 16;
            this.toolTip14.SetToolTip(this.comboBox1, "Resimler arasındaki geçiş saniyesini belirler.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Bekleme Süresi :";
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "Resimleri Göster";
            // 
            // toolTip4
            // 
            this.toolTip4.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip4.ToolTipTitle = "Resimlerin Yolu";
            // 
            // toolTip5
            // 
            this.toolTip5.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip5.ToolTipTitle = "Yeniden Boyutlandırma";
            // 
            // toolTip8
            // 
            this.toolTip8.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip8.ToolTipTitle = "Slide Show";
            // 
            // toolTip9
            // 
            this.toolTip9.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip9.ToolTipTitle = "Önceki Resim";
            // 
            // toolTip12
            // 
            this.toolTip12.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip12.ToolTipTitle = "Genişlik";
            // 
            // toolTip13
            // 
            this.toolTip13.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip13.ToolTipTitle = "Yükseklik";
            // 
            // toolTip10
            // 
            this.toolTip10.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip10.ToolTipTitle = "Sonraki Resim";
            // 
            // toolTip14
            // 
            this.toolTip14.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip14.ToolTipTitle = "Resimler Arası Geçiş";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.ResimAcToolStripMenuItem,
            this.boyutlandırToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1033, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.açToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.açToolStripMenuItem.Text = "Aç...";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet...";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // ResimAcToolStripMenuItem
            // 
            this.ResimAcToolStripMenuItem.Name = "ResimAcToolStripMenuItem";
            this.ResimAcToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.ResimAcToolStripMenuItem.Text = "Resim Seç";
            this.ResimAcToolStripMenuItem.Click += new System.EventHandler(this.ResimAcToolStripMenuItem_Click);
            // 
            // boyutlandırToolStripMenuItem
            // 
            this.boyutlandırToolStripMenuItem.Name = "boyutlandırToolStripMenuItem";
            this.boyutlandırToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.boyutlandırToolStripMenuItem.Text = "Boyutlandır";
            this.boyutlandırToolStripMenuItem.Click += new System.EventHandler(this.boyutlandırToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renkSeçToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // renkSeçToolStripMenuItem
            // 
            this.renkSeçToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkaplanRengiToolStripMenuItem1,
            this.yazıRengiToolStripMenuItem});
            this.renkSeçToolStripMenuItem.Name = "renkSeçToolStripMenuItem";
            this.renkSeçToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.renkSeçToolStripMenuItem.Text = "Renk Seç";
            // 
            // arkaplanRengiToolStripMenuItem1
            // 
            this.arkaplanRengiToolStripMenuItem1.Name = "arkaplanRengiToolStripMenuItem1";
            this.arkaplanRengiToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.arkaplanRengiToolStripMenuItem1.Text = "Arkaplan Rengi";
            this.arkaplanRengiToolStripMenuItem1.Click += new System.EventHandler(this.arkaplanRengiToolStripMenuItem1_Click);
            // 
            // yazıRengiToolStripMenuItem
            // 
            this.yazıRengiToolStripMenuItem.Name = "yazıRengiToolStripMenuItem";
            this.yazıRengiToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.yazıRengiToolStripMenuItem.Text = "Yazı Rengi";
            this.yazıRengiToolStripMenuItem.Click += new System.EventHandler(this.yazıRengiToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Kalite";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(299, 586);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Genişlik:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(299, 610);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Yükseklik:";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblW.Location = new System.Drawing.Point(379, 586);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(0, 18);
            this.lblW.TabIndex = 10;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblH.Location = new System.Drawing.Point(390, 610);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(0, 18);
            this.lblH.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_onceki);
            this.groupBox1.Controls.Add(this.button_sonraki);
            this.groupBox1.Controls.Add(this.button_Show);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(14, 489);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 139);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Slide Show";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 25;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 635);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox_ResimDizini);
            this.Controls.Add(this.pictureBox_Resimler);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adibe Okömşop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Resimler)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox_ResimDizini;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_onceki;
        private System.Windows.Forms.Button button_sonraki;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Show;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.ToolTip toolTip9;
        private System.Windows.Forms.ToolTip toolTip12;
        private System.Windows.Forms.ToolTip toolTip13;
        private System.Windows.Forms.ToolTip toolTip10;
        private System.Windows.Forms.ToolTip toolTip14;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.PictureBox pictureBox_Resimler;
        private System.Windows.Forms.ToolStripMenuItem ResimAcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblW;
        public System.Windows.Forms.Label lblH;
        private System.Windows.Forms.ToolStripMenuItem boyutlandırToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arkaplanRengiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yazıRengiToolStripMenuItem;
        public System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
    }
}


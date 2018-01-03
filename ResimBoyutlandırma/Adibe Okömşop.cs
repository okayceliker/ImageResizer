using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace ResimBoyutlandırma
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        //    this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            if (pictureBox_Resimler.Image == null)
            {
                kaydetToolStripMenuItem.Enabled = true;
            }
            boyutlandırToolStripMenuItem.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            lblW.Enabled = false;
            lblH.Enabled = false;
        }
        int genislik = 0, yukseklik = 0;
        int imgindex;
        string resimyolu = string.Empty;
        Bitmap bmp = null;
        public Int64 kalite;
        public string cH;
        public string cW;
        public bool ResmiOrtala = false;
        public bool ResmiSigdir = false;
        
        private Bitmap RotatePhoto(RotateFlipType value)
        {
            Bitmap Bmp = new Bitmap(pictureBox_Resimler.Image);

            Bmp.RotateFlip(value);

            if (Bmp.Width >= Bmp.Height)
            {
                pictureBox_Resimler.Width = 500;
                pictureBox_Resimler.Height = Convert.ToInt32(Math.Round(500 / (Convert.ToDouble(Bmp.Width) / Convert.ToDouble(Bmp.Height))));
            }
            else
            {
                pictureBox_Resimler.Width = Convert.ToInt32(Math.Round(375 / (Convert.ToDouble(Bmp.Height) / Convert.ToDouble(Bmp.Width))));
                pictureBox_Resimler.Height = 375;
            }
            lblW.Text = Bmp.Width.ToString();
            lblH.Text = Bmp.Height.ToString();

            return Bmp;
        }

        private void ListBox_ResimDizini_SelectedIndexChanged(object sender, EventArgs e)
        {
            string resimgoster = listBox_ResimDizini.SelectedItem.ToString();
            pictureBox_Resimler.ImageLocation = resimgoster;
            string ad = listBox_ResimDizini.SelectedItem.ToString();
            string[] parcalar = ad.Split('\\');
            label3.Text = "Görüntülenen Resim: " + parcalar[parcalar.Count() - 1].ToString();
        }

        private void button_onceki_Click(object sender, EventArgs e)
        {
            if (imgindex > 0)
            {
                imgindex -= 1;
                if (imgindex == 0)
                {
                    button_onceki.Enabled = false;
                }
                if (imgindex < listBox_ResimDizini.Items.Count - 1)
                    button_sonraki.Enabled = true;
                listBox_ResimDizini.SelectedIndex = imgindex;
            }
        }

        private void button_sonraki_Click(object sender, EventArgs e)
        {
            if (imgindex < listBox_ResimDizini.Items.Count - 1)
            {
                imgindex += 1;
                if (imgindex == listBox_ResimDizini.Items.Count - 1)
                    button_sonraki.Enabled = false;
                if (imgindex > 0)
                    button_onceki.Enabled = true;
                listBox_ResimDizini.SelectedIndex = imgindex;
            }
        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            if (button_Show.Text == "Slide Show")
            {
                button_Show.Text = "Durdur";
                timer1.Interval = int.Parse(comboBox1.Text) * 1000;
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                button_Show.Text = "Slide Show";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button_sonraki.PerformClick();
        }

        private void textBox_genislik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar < 57)
            {
                e.Handled = false;
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox_yukseklik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar < 57)
            {
                e.Handled = false;
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dizin = new FolderBrowserDialog();
            if (dizin.ShowDialog() == DialogResult.OK)
            {
                listBox_ResimDizini.Items.Clear();
                string[] dosyalar = Directory.GetFiles(dizin.SelectedPath);
                foreach (string ydosya in dosyalar)
                {
                    if (ydosya.EndsWith(".png") || ydosya.EndsWith(".jpg"))
                    {
                        listBox_ResimDizini.Items.Add(ydosya);
                    }
                }
            }

        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quality q = new Quality();
            q.f = this;
            q.ShowDialog();
        }

        private void arkaplanRenkleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tus;
            tus = colorDialog1.ShowDialog();
            if (tus == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void yazıRengiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult tus;
            tus = colorDialog1.ShowDialog();
            if (tus == DialogResult.OK)
            {
                this.ForeColor = colorDialog1.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
            comboBox1.SelectedIndex = 0;
        }

        private void ResimAcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Lütfen Dosya Seçiniz";
            openFileDialog1.Filter = "Resim Dosyası (*.jpg)|*.jpg| Tüm Dosyalar (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(openFileDialog1.FileName);

                if (bmp.Width >= bmp.Height)
                {
                    pictureBox_Resimler.Width = 717;
                    pictureBox_Resimler.Height = Convert.ToInt32(Math.Round(699 / (Convert.ToDouble(bmp.Width) / Convert.ToDouble(bmp.Height))));
                }
                else
                {
                    pictureBox_Resimler.Width = Convert.ToInt32(Math.Round(603 / (Convert.ToDouble(bmp.Height) / Convert.ToDouble(bmp.Width))));
                    pictureBox_Resimler.Height = 524;
                }

                pictureBox_Resimler.Image = bmp;
                pictureBox_Resimler.SizeMode = PictureBoxSizeMode.StretchImage;
                cH = bmp.Height.ToString();
                cW = lblW.Text = bmp.Width.ToString();
                lblW.Text = bmp.Width.ToString();
                lblH.Text = bmp.Height.ToString();
                label3.Text = "Görüntülenen Resim: " + openFileDialog1.SafeFileName;
                boyutlandırToolStripMenuItem.Enabled = true;
                label6.Enabled = true;
                label7.Enabled = true;
                lblW.Enabled = true;
                lblH.Enabled = true;
            }
        }

        private void boyutlandırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boyutlandırma rsz = new Boyutlandırma();
            rsz.f = this;
            rsz.ShowDialog();
        }

        private void sayfaYapısıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
            }

        }

        private void sayfaYazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkında about = new Hakkında();
            about.ShowDialog();
        }

        private void arkaplanRengiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult tus;
            tus = colorDialog1.ShowDialog();
            if (tus == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tus;
            tus = colorDialog1.ShowDialog();
            if (tus == DialogResult.OK)
            {
                this.ForeColor = colorDialog1.Color;
            }
        }

        private void sayfaYapısıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
            }
        }

        private void sayfayıYazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
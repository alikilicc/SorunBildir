using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorunBildir
{
    public partial class GirisEkranı : Form
    {
    
      public static String otelAdi;
        public GirisEkranı()
        {
            InitializeComponent();
        }
        
        private void textBox1_Click(object sender, EventArgs e)
        {
            textbKullaniciAdi.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textbSifre.Text = "";
        }

        private void butonGiris_Click(object sender, EventArgs e)
        {
            if (textbKullaniciAdi.Text == "yönetici" && textbSifre.Text == "admin")
            {
                
                SorunGoster objeSorunGoster = new SorunGoster();
                objeSorunGoster.Show();
                this.Hide();

            }
            if (textbKullaniciAdi.Text=="nidya suit" && textbSifre.Text=="nidya esenyurt")
            {
                otelAdi = "Nidya Hotel Esenyurt";
                Form1 objeForm1 = new Form1();
                objeForm1.Show();
                this.Hide();

            }
            if (textbKullaniciAdi.Text == "nidya galataport" && textbSifre.Text == "nidya beşiktaş")
            {
                otelAdi = "Nidya Hotel Galataport";
                Form1 objeForm1 = new Form1();
                objeForm1.Show();
                this.Hide();

            }
            if (textbKullaniciAdi.Text == "holiday resort" && textbSifre.Text == "holiday resort bodrum")
            {
                otelAdi = "Bodrum Holiday Resort";
                Form1 objeForm1 = new Form1();
                objeForm1.Show();
                this.Hide();

            }
            if (textbKullaniciAdi.Text == "marina boutique" && textbSifre.Text == "marina fethiye")
            {
                otelAdi = "Marina Boutique Hotel Fethiye";
                Form1 objeForm1 = new Form1();
                objeForm1.Show();
                this.Hide();

            }
            if (textbKullaniciAdi.Text == "perili bay resort" && textbSifre.Text == "perili bay datca")
            {
                otelAdi = "Datca Perili Bay Resort";
                Form1 objeForm1 = new Form1();
                objeForm1.Show();
                this.Hide();

            }
        }
    }
}

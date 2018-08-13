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



        private void butonGiris_Click(object sender, EventArgs e)
        {
            if (textbKullaniciAdi.Text == "yönetici")
            {

                SorunGoster objeSorunGoster = new SorunGoster();
                objeSorunGoster.Show();
                this.Hide();

            }
            else if (textbKullaniciAdi.Text != string.Empty && textbKullaniciAdi.Text != "yönetici")
            {
                otelAdi = textbKullaniciAdi.Text;
                Form1 objeForm1 = new Form1();
                objeForm1.Show();
                this.Hide();
            }
            else MessageBox.Show("İşletme Adını Girmediniz...");
            
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorunBildir
{
    public partial class DetayliSorunGoster : Form
    {
        public DetayliSorunGoster()
        {
            InitializeComponent();
            veritabaniGetir();
            goster();
        }

        private void butonGeri_Click(object sender, EventArgs e)
        {
            SorunGoster sorunGoster = new SorunGoster();
            sorunGoster.Show();
            this.Hide();
        }
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-8FUAC6A\\SQLEXPRESS;Database=SorunBildirDB;Trusted_Connection=True;");


        private void veritabaniGetir()
        {

            baglanti.Open();
            String kuyruk = "select * from Sorun_Bilgileri where [kullanici_id]=" + SorunGoster.id;
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kuyruk, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView1.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            baglanti.Close();

        }
        private void goster()
        {
            butonBilAdi.Text =butonBilAdi.Text+" "+ dataGridView1.Rows[0].Cells[3].Value.ToString();
            butonEtkiAlan.Text = butonEtkiAlan.Text + " " + dataGridView1.Rows[0].Cells[7].Value.ToString();
            butonGateWay.Text = butonGateWay.Text + " " + dataGridView1.Rows[0].Cells[6].Value.ToString();
            butonKullAdi.Text = butonKullAdi.Text + " " + dataGridView1.Rows[0].Cells[2].Value.ToString();
            butonMac.Text = butonMac.Text + " " + dataGridView1.Rows[0].Cells[5].Value.ToString();
            butonIP.Text = butonIP.Text + " " + dataGridView1.Rows[0].Cells[4].Value.ToString();
            textbSorun.Text = textbSorun.Text + " " + dataGridView1.Rows[0].Cells[8].Value.ToString();
        }
    }
}






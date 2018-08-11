using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace SorunBildir
{
    public partial class SorunGoster : Form
    {
        public static int id;   
        public SorunGoster()
        {
           
            InitializeComponent();
            timer1.Interval = 3000;
            timer1.Start();
            
        }
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-8FUAC6A\\SQLEXPRESS;Database=SorunBildirDB;Trusted_Connection=True;");
        private void veritabaniGetir()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Sorun_Bilgileri", baglanti);
            SqlDataReader oku =komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["kullanici_id"].ToString();
                ekle.SubItems.Add(oku["otel_adi"].ToString());
                ekle.SubItems.Add(oku["kullanici_adi"].ToString());
                ekle.SubItems.Add(oku["sorun"].ToString());
                listView1.Items.Add(ekle);

            }
            
            baglanti.Close();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            veritabaniGetir();
        }
        ListViewItem eklee = new ListViewItem();
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*
            DetayliSorunGoster detayliSorunGoster = new DetayliSorunGoster();
            detayliSorunGoster.Show();
            this.Hide();
            */
            if (listView1.SelectedIndices.Count > 0) //Secili satır varmı yokmu kontrol ediliyor.
                id =int.Parse (listView1.SelectedItems[0].SubItems[0].Text);
            DetayliSorunGoster detayliSorunGoster = new DetayliSorunGoster();
            detayliSorunGoster.Show();
            
        }

    }
    
}

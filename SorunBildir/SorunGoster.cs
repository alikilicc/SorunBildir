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
        const string constr = "Server=PC1-BILGISAYAR\\SQLEXPRESS;Database=test;Trusted_Connection=True;";

        public static int id;
        public SorunGoster()
        {

            InitializeComponent();
            veritabaniGetir();
        
            timer1.Interval = 3000;
            timer1.Start();

        }
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-8FUAC6A\\SQLEXPRESS;Database=SorunBildirDB;Trusted_Connection=True;");
        private void veritabaniGetir()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Sorun_Bilgileri", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
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
        private void control()
        {
             for(int i=0;i<listView1.Items.Count; i++)
             {
                if (listView1.Items[i].Checked)
                {
                    timer1.Stop(); break;
                }
                else timer1.Start();
                    
             }
        }


         private void timer1_Tick(object sender, EventArgs e)
         {


            control();
             veritabaniGetir();
         }
        ListViewItem eklee = new ListViewItem();
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (listView1.SelectedIndices.Count > 0) //Secili satır varmı yokmu kontrol ediliyor.
                id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DetayliSorunGoster detayliSorunGoster = new DetayliSorunGoster();
            detayliSorunGoster.Show();

        }

        private void butonSil_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

                        for (int i = 0; i < listView1.Items.Count; i++)
                            if (listView1.Items[i].Checked) // i değişken değeri kadar seçili checkbox için yapılacak işlemi belirtiyorum
                            {
                                string ekle = string.Format("insert into Cozulen_Sorunlar (kullanici_adi, isletme_adi, sorun) values('" + listView1.CheckedItems[0].SubItems[2].Text + "', '" + listView1.CheckedItems[0].SubItems[1].Text + "','" + listView1.CheckedItems[0].SubItems[3].Text + "')");
                                string sorgu1 = string.Format(" delete from Sorun_Bilgileri where kullanici_id ='{0}'", listView1.Items[i].SubItems[0].Text);
                                SqlCommand eklee = new SqlCommand(ekle, baglanti);
                                eklee.ExecuteNonQuery();
                                SqlCommand sil = new SqlCommand(sorgu1, baglanti);
                                sil.ExecuteNonQuery();

                            }
                        listView1.Items.Clear(); // ListView öğelerini temizliyorum
                                                 // Silinmeyen Öğeleri ListView içine dolduruyorum (yenileme yapmış oluyorum)
                        baglanti.Close();
        }
    }
}
    


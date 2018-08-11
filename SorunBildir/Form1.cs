using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Management;
using System.Data.SqlClient;
using System.Data;

namespace SorunBildir
{
    public partial class Form1 : Form
    {
        String tut;
        const string constr = "Server=DESKTOP-8FUAC6A\\SQLEXPRESS;Database=SorunBildirDB;Trusted_Connection=True;";

        IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
        public Form1()
        {
            InitializeComponent();
        }

        private void ButonBilgiEkle_Click(object sender, EventArgs e)
        {

            IPHostEntry host;
            String yerelIp = "?";
            SelectQuery query = new SelectQuery("Win32_ComputerSystem");
            host = Dns.GetHostEntry(Dns.GetHostName());
            NetworkInterface[] arayuz = NetworkInterface.GetAllNetworkInterfaces();
            textbKullAdi.Text = Environment.UserName;   //Kullanıcı Adı  
            textbBilAdi.Text = Dns.GetHostName();      //Bilgisayar Adı
            //tip= NetworkInterface.GetIsNetworkAvailable;
            PhysicalAddress mac;
            mac = arayuz[0].GetPhysicalAddress();
            String mac2 = mac.ToString();
            textbMac.Text = GetMacAdres();
            textbGateway.Text = GetDefaultGateway().ToString();
            textbEtkiAlani.Text = System.Environment.UserDomainName;
            // textbErisimTuru.Text = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;


            //Bunu yapmamızın sebebi burdan gelecek mac ornegin 1123431f23 şeklinde olacak MacAl fonksiyonu bunu 11:23:43:1f:23şeklinde bize gonderecek.


            //IP yi alan kod
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    yerelIp = ip.ToString();
                    textbIP.Text = yerelIp;
                }
            }



        }
        public IPAddress GetDefaultGateway()
        {
            IPAddress result = null;
            var cards = NetworkInterface.GetAllNetworkInterfaces().ToList();
            if (cards.Any())
            {
                foreach (var card in cards)
                {
                    var props = card.GetIPProperties();
                    if (props == null)
                        continue;

                    var gateways = props.GatewayAddresses;
                    if (!gateways.Any())
                        continue;

                    var gateway =
                        gateways.FirstOrDefault(g => g.Address.AddressFamily.ToString() == "InterNetwork");
                    if (gateway == null)
                        continue;

                    result = gateway.Address;
                    break;
                };
            }

            return result;
        }
        private string GetMacAdres()
        {
            using (var m = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                foreach (var o in m.GetInstances())
                {
                    var obje = (ManagementObject)o;
                    if ((bool)obje["IPEnabled"])
                    {
                        return obje["MacAddress"].ToString();
                    }
                }
            }
            return string.Empty;
        }

        private void butonGonder_Click(object sender, EventArgs e)
        {
            if (textbSoruNe.Text != string.Empty)
            {
              
                tut = GirisEkranı.otelAdi;
                try
                {
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        con.Open();
                        if (con.State == ConnectionState.Open)
                        {
                            SqlCommand com = new SqlCommand("insert into Sorun_Bilgileri (otel_adi,kullanici_adi, bilgisayar_adi, ip_adres," +
                                " mac_adres, gateway_adres, etki_alani, sorun) " +
                                "values('"+ tut +"','" + textbKullAdi.Text + "', '" + textbBilAdi.Text + "', " +
                                "'" + textbIP.Text + "', '" + textbMac.Text + "', " +
                                "'" + textbGateway.Text + "', '" + textbEtkiAlani.Text + "', " +
                                "'" + textbSoruNe.Text + "')", con);
                            int retVal = com.ExecuteNonQuery();
                            if (retVal > 0)
                            {
                                MessageBox.Show("SORUN İLETİLDİ...");
                            }
                        }
                        else
                            MessageBox.Show("BAĞLANTI SAĞLANMADI...");
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
            else
                MessageBox.Show("Lütfen Sorunu Açıklayınız");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SorunGoster ob = new SorunGoster();
                ob.Show();
            this.Hide();

        }
    }
}


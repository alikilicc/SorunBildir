using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Management;

namespace SorunBildir
{
    public partial class Form1 : Form
    {
        IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
        public Form1()
        {
            InitializeComponent();
        }

        private void ButonBilgiEkle_Click(object sender, EventArgs e)
        {
            IPHostEntry host;
            String yerelIp = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            NetworkInterface[] arayuz=NetworkInterface.GetAllNetworkInterfaces();
            textbKullAdi.Text = Environment.UserName;   //Kullanıcı Adı  
            textbBilAdi.Text = Dns.GetHostName();      //Bilgisayar Adı
            //tip= NetworkInterface.GetIsNetworkAvailable;
            PhysicalAddress mac;
            mac = arayuz[0].GetPhysicalAddress();
            String mac2 = mac.ToString();     
            textbMac.Text = GetMacAdres();
            textbGateway.Text = GetDefaultGateway().ToString();
      

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
            foreach (NetworkInterface tip in arayuz)
            {
                textbErisimTuru.Text = tip.Name;
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

    }
}


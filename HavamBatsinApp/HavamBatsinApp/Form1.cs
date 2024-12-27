using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HavamBatsinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = "https://api.openweathermap.org/data/2.5/weather?lat=39.773438&lon=30.519283&appid=3f200d39694920c99e1530f410fa1564&mode=xml&units=metric&lang=tr";
            XDocument havadurumu = XDocument.Load(path);
            XElement current = havadurumu.Root;

            //string sicaklik = current.Element("temperature").Attribute("value").Value;
            double sicaklik = Convert.ToDouble(current.Element("temperature").Attribute("value").Value.Replace('.', ',')); //Bu şekilde mevcut derece yuvarlanıyor.
            lbl_sicaklik.Text = Convert.ToInt32(sicaklik).ToString() + "℃";

            string sehir = current.Element("city").Attribute("name").Value;
            lbl_sehir.Text = sehir;

            //string hissedilen = current.Element("feels_like").Attribute("value").Value;
            double hissedilen = Convert.ToDouble(current.Element("feels_like").Attribute("value").Value.Replace('.', ',')); 
            lbl_hissedilen.Text = "Hissedilen: " + Convert.ToInt32(hissedilen).ToString() + "℃";

            string hava = current.Element("weather").Attribute("value").Value;
            string ikon = current.Element("weather").Attribute("icon").Value;
            string imagePath = "https://openweathermap.org/img/wn/" + ikon + "@2x.png"; //güvenlik hatası alırsan https kısmındaki s harfini sil.
            pictureBox1.ImageLocation = imagePath;
            lbl_hava.Text = hava;

            //https://openweathermap.org/img/wn/10d@2x.png
            
        }
    }
}

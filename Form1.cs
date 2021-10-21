using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Net;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string city;
        private void button1_Click(object sender, EventArgs e)
        {
            
            city = txtCity.Text;

            string url = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=91ad6359eebf418e8f9163130212010&q={0}&days=1&aqi=no&alerts=no", city);

            XDocument doc = XDocument.Load(url);

            string iconUrl = (string)doc.Descendants("icon").FirstOrDefault();

            WebClient client = new WebClient();

            byte[] image = client.DownloadData("http:" + iconUrl);

            MemoryStream stream = new MemoryStream(image);

            Bitmap newBitMap = new Bitmap(stream);
            string maxtemp = (string)doc.Descendants("maxtemp_c").FirstOrDefault();
            string mintemp = (string)doc.Descendants("mintemp_c").FirstOrDefault();

            string country = (string)doc.Descendants("country").FirstOrDefault();
            string region = (string)doc.Descendants("region").FirstOrDefault();
            string lat = (string)doc.Descendants("lat").FirstOrDefault();
            string lon = (string)doc.Descendants("lon").FirstOrDefault();

            string Tz = (string)doc.Descendants("tz_id").FirstOrDefault();
            string currentTime = (string)doc.Descendants("localtime").FirstOrDefault();

            string cloud = (string)doc.Descendants("text").FirstOrDefault();

            Bitmap icon = newBitMap;

            txtMaxTemp.Text = maxtemp;
            txtMinTemp.Text = mintemp;

            txtRegion.Text = region;
            txtLat.Text = lat;
            txtLon.Text = lon;

            txtCurrentTime.Text = currentTime;
            txtTimeZ.Text = Tz;

            txtCountry.Text = country;
            lblWeatherCon.Text = cloud;

            pictureBox1.Image = icon; 
        }

        private void txtMaxTemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Country", typeof(string));
            dt.Columns.Add("Date & Time", typeof(string));
            dt.Columns.Add("Max Temp", typeof(string));
            dt.Columns.Add("Min Temp", typeof(string));
            dt.Columns.Add("Conditions", typeof(string));
            dt.Columns.Add("Image", typeof(string));

            city = txtCity.Text;

            string url = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=91ad6359eebf418e8f9163130212010&q={0}&days=7&aqi=no&alerts=no", city);

            XDocument doc = XDocument.Load(url);

            string hour = (string)doc.Descendants("hour").FirstOrDefault();
            DateTime now = DateTime.Now;

            foreach(var npc in doc.Descendants("hour"))
            {
                string iconUrl = (string)npc.Descendants("icon").FirstOrDefault();
                WebClient client = new WebClient();
                byte[] image = client.DownloadData("http:" + iconUrl);
                MemoryStream stream = new MemoryStream(image);

                Bitmap newBitmap = new Bitmap(stream);

                dt.Rows.Add(new object[]
                {
                    (string)doc.Descendants("country").FirstOrDefault(),
                    (string)npc.Descendants("time").FirstOrDefault(),
                    (string)doc.Descendants("maxtemp_c").FirstOrDefault(),
                    (string)doc.Descendants("mintemp_c").FirstOrDefault(),
                    (string)npc.Descendants("text").FirstOrDefault(),
                    newBitmap
                });
            }
            dataGridView1.DataSource = dt;
        }
    }
}

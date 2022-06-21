using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using QuickType;

namespace Http_get_And_post
{
    public partial class JsonVerisi : Form
    {
        public JsonVerisi()
        {
            InitializeComponent();


            
        }

        private void JsonVerisi_Load(object sender, EventArgs e)
        {


            using (var client = new HttpClient())
            {
                

                var endpoint = new Uri("http://api.weatherstack.com/current?access_key=95b1ff616ab950db9cd65bb65c9b3db7&query=New%20York");
                var result = client.GetAsync(endpoint).Result;
                string json1 = result.Content.ReadAsStringAsync().Result;
                
                Temperatures t = new Temperatures();
                var a = Temperatures.FromJson(json1);
                Console.WriteLine(a.Current.WindSpeed);
                label2.Text = Convert.ToString(a.Location.Localtime);
                label4.Text = Convert.ToString(a.Current.WindSpeed);
                



            }
        }
    }

}

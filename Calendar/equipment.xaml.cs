using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calendar
{
    /// <summary>
    /// Interaction logic for equipment.xaml
    /// </summary>
    public partial class equipment : Page
    {
        public equipment()
        {
            InitializeComponent();
            using (HttpClient client = new HttpClient())
            {
                var endopint = new Uri("https://mekelektro.com/orders/");
                var res = client.GetAsync(endopint).Result.Content.ReadAsStringAsync().Result;
                string json = res;
                //dynamic jsonData = JsonConvert.DeserializeObject(json);
                ApiCLass[] apiCLasses = JsonConvert.DeserializeObject<ApiCLass[]>(json);
                

                foreach (var  apiCLass in apiCLasses)
                {
                    textInfo.Text = $"Start: {apiCLass.order_start_date}";
                }

            }
        }

    }
}

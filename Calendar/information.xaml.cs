using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Calendar
{
    /// <summary>
    /// Interaction logic for information.xaml
    /// </summary>
    public partial class information : Window
    {
        public information()
        {
            InitializeComponent();
        }

        private void stuff(object sender, SelectionChangedEventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                var endpoint = new Uri("ApiUrl");
                var res = client.GetAsync(endpoint).Result.Content.ReadAsStringAsync().Result;
                string json = res;
                ApiCLass[] apiCLasses = JsonConvert.DeserializeObject<ApiCLass[]>(json);

                userInfo.Text = "";

                foreach (var apiCLass in apiCLasses)
                {
                    string name = apiCLass.name;
                    string stock = apiCLass.current_stock;

                    userInfo.Text += name + "\n";
                }
            }
        }
    }
}

using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Net.Http;
using Newtonsoft.Json;

namespace Calendar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // functionality to call API and print out the event date and time
        private void dateChanged(object sender, SelectionChangedEventArgs e)
        {
            textPanel.Text = txtCalendar.SelectedDate?.ToShortDateString();
            var selectedDate = txtCalendar.SelectedDate.Value.ToShortDateString();

            using (HttpClient client = new HttpClient())
            {
                var endpoint = new Uri("ApiUrl");
                var res = client.GetAsync(endpoint).Result.Content.ReadAsStringAsync().Result;
                string json = res;
                ApiCLass[] apiCLasses = JsonConvert.DeserializeObject<ApiCLass[]>(json);

                eventInfo.Text = "";

                foreach (var apiCLass in apiCLasses)
                {
                    DateTime dateTime;
                    DateTime timeDate;
                    string timetest = apiCLass.order_start_date;
                    string time = apiCLass.order_start_date;
                    DateTime.TryParseExact(timetest, "yyyy-MM-ddTHH:mm:ss.fffZ", CultureInfo.CurrentCulture, DateTimeStyles.AssumeUniversal, out dateTime);
                    DateTime.TryParseExact(time, "yyyy-MM-ddTHH:mm:ss.fffZ", CultureInfo.CurrentCulture, DateTimeStyles.AssumeUniversal, out timeDate);
                    string changedTime = timeDate.ToShortTimeString();
                    string changedDate = dateTime.ToShortDateString();

                    if (selectedDate == changedDate)
                    {
                        eventInfo.Text += changedDate + ": " + changedTime + "\n";
                    }
                }
            }

        }

        //functionality for the button "tavaraluettelo"
        private void buttonClick(object sender, RoutedEventArgs e)
        {
            ItemInfo itemInfo = new ItemInfo();
            itemInfo.Show();
        }

        //functionality for the button "kalustoinfo". closes when pressed again
        private void equipmentClick(object sender, RoutedEventArgs e)
        {
            if (Frame.Content is equipment)
            {
                Frame.Navigate(Frame.Source);
            }
            else
            {
                Frame.Content = new equipment();
            }
        }

        Grid grid = new Grid();

        private void createList_Click(object sender, RoutedEventArgs e)
        {
            // Create a new ListBox
            listBox = new ListBox();
            listBox.Visibility = Visibility.Visible;


            listBox.Margin = new Thickness(50);
            listBox.Width = 200;
            listBox.Height = 150;


            Grid.SetRow(listBox, 1);
            Grid.SetColumn(listBox, 0);
            grid.Children.Add(listBox);
        }

        private void openListButton_Click(object sender, RoutedEventArgs e)
        {

            if (listBox.Visibility == Visibility.Collapsed)
            {
                listBox.Visibility = Visibility.Visible;
            }
            else
            {
                listBox.Visibility = Visibility.Collapsed;
            }
        }


    }
}

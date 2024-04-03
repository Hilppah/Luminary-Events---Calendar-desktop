using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dateChanged(object sender, SelectionChangedEventArgs e)
        {
            textPanel.Text = txtCalendar.SelectedDate.ToString();
        }

        //functionality for the button "tavaraluettelo"
        private void buttonClick(object sender, RoutedEventArgs e)
        {
            ItemInfo itemInfo = new ItemInfo();
            itemInfo.Show();
        }

        //functionality for the button "kalustoinfo"
        private void equipmentClick(object sender, RoutedEventArgs e)
        {
            Frame.Content = new equipment();
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

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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

        private void dateChanged(object sender, SelectionChangedEventArgs e) {
            textPanel.Text = txtCalendar.SelectedDate.ToString();
        }

        private void buttonClick(object sender, RoutedEventArgs e)
        {
            ItemInfo itemInfo = new ItemInfo();
            itemInfo.Show();
        }
    }
}
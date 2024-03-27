using System;
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
        DateInfo myDateInfo;
        public MainWindow()
        {
            myDateInfo = new DateInfo()
            {
                SelectedDate = DateTime.Now,
            };
            InitializeComponent();

            textPanel.DataContext = myDateInfo;
        }

        public class DateInfo : INotifyPropertyChanged
        {
            private DateTime? selectedDate;

            public DateTime? SelectedDate
            {
                get
                {
                    return this.selectedDate;
                }
                set
                {
                    if (this.selectedDate != value)
                    {
                        this.selectedDate = value;
                        pChanged("SelectedDate");
                    }
                }
            }

            protected virtual void pChanged(string pName)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(pName));
                }

            }
            public event PropertyChangedEventHandler PropertyChanged;
        }
    }
}

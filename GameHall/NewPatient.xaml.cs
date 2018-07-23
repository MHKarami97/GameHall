using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace GameHall
{
    /// <summary>
    /// Interaction logic for NewPatient.xaml
    /// </summary>
    public partial class NewPatient : Window
    {
        public NewPatient()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            TimeText.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute;
            DateText.Text = main.PersianCalender.SelectedDate.Year + "/" + main.PersianCalender.SelectedDate.Month + "/" + main.PersianCalender.SelectedDate.Day;
        }

        private void BtnCancel(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void BtnAdd(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}

using System;
using System.Windows;
using System.Windows.Input;
namespace GameHall
{
    /// <summary>
    /// Interaction logic for ReserveTime.xaml
    /// </summary>
    public partial class ReserveTime
    {
        public ReserveTime()
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
            Close();
        }

        private void BtnAdd(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}

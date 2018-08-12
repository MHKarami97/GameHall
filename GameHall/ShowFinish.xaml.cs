using System;
using System.Windows;
using System.Windows.Input;

namespace GameHall
{
    /// <summary>
    /// Interaction logic for ShowFinish.xaml
    /// </summary>
    public partial class ShowFinish
    {
        public ShowFinish(string username, string sTime, string eTime, string totalPrice)
        {
            try
            {
                InitializeComponent();

                startTime.Text = sTime;
                endTime.Text = eTime;
                nameUser.Text = username;
                price.Text = totalPrice;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }            
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnCancel(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void MoveWindows(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}

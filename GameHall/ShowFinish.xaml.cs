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
using GameHall.DataBase;

namespace GameHall
{
    /// <summary>
    /// Interaction logic for ShowFinish.xaml
    /// </summary>
    public partial class ShowFinish : Window
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

using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using GameHall.DataBase;
using Telerik.Windows;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.GridView;

namespace GameHall
{
    /// <summary>
    /// Interaction logic for PlayingList.xaml
    /// </summary>
    public partial class PlayingList
    {
        public PlayingList()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var db=new GameHalldbEntities();

            var result = from a in db.playings
                where a.status.Equals(false)
                orderby a.Id
                select a;

            playerList.ItemsSource = result.ToList();
        }

        private void MoveWindows(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void BtnCancel(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void FinishTime(object sender, RadRoutedEventArgs radRoutedEventArgs)
        {
            var time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        }

        private void FinishClick(object sender, RadRoutedEventArgs e)
        {
            RadMenuItem item = e.OriginalSource as RadMenuItem;
            //implement the logic regarding the instance here.
            //MessageBox.Show(e);
        }


    }
}

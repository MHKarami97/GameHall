using System.Linq;
using System.Windows;
using System.Windows.Input;
using GameHall.DataBase;

namespace GameHall
{
    /// <summary>
    /// Interaction logic for UserList.xaml
    /// </summary>
    public partial class UserList
    {
        public UserList()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var db=new GameHalldbEntities();
            playerList.ItemsSource = db.players.ToList();
        }

        private void MoveWindows(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void BtnCancel(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}

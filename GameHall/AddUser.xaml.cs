using System;
using System.Windows;
using System.Windows.Input;
using GameHall.DataBase;

namespace GameHall
{
    /// <summary>
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser
    {
        public AddUser()
        {
            InitializeComponent();
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

        private void BtnAdd(object sender, MouseButtonEventArgs e)
        {
            var db = new GameHalldbEntities();            

            var newPlayer = new player
            {
                name = name.Text,
                lastname = lastname.Text
            };

            db.players.Add(newPlayer);

            if (Convert.ToBoolean(db.SaveChanges()))
            {
                successAdd.Opacity = 1;
                name.Text = "";
                lastname.Text = "";
            }
            else
            {
                notSuccessAdd.Opacity = 1;
                name.Text = "";
                lastname.Text = "";
            }
        }
    }
}

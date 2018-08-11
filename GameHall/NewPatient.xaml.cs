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
            var db = new GameHalldbEntities();

            table.ItemsSource = db.hallTables.ToList();
            table.DisplayMemberPath = "number";

            TimeText.Text = Convert.ToString(DateTime.Now.Hour);
            TimeMin.Text = Convert.ToString(DateTime.Now.Minute);
            DateYear.Text = Convert.ToString(main.PersianCalender.SelectedDate.Year);
            DateMonth.Text = Convert.ToString(main.PersianCalender.SelectedDate.Month);
            DateDay.Text = Convert.ToString(main.PersianCalender.SelectedDate.Day);
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
            var time= DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            var newPlaying = new playing
            {
                startTime = Convert.ToDateTime(time),
                description = information.Text,
                status = false,
                place = Convert.ToInt32(table.Text)
            };

            db.playings.Add(newPlaying);

            if (Convert.ToBoolean(db.SaveChanges()))
            {
                success.Opacity = 1;

            }
            else
            {
                noSuccess.Opacity = 0;
            }
        }
    }
}

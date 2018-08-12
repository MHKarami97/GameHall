using System;
using System.Globalization;
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

        private void FinishClick(object sender, RoutedEventArgs e)
        {
            var db = new GameHalldbEntities();

            var time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");           
            var secondLast= DateTime.Now.Subtract(DateTime.MinValue).TotalSeconds;

            var getSetting = (from a in db.settings
                where a.Id.Equals(1)
                select a).SingleOrDefault();

            if (getSetting != null)
            {
                var oneHourPrice = getSetting.OneHourPrice;                

                object item = playerList.SelectedItem;
                var id = ((playing)item).Id;

                var qGet = (from a in db.playings
                    where a.Id.Equals(id)
                    select a).SingleOrDefault();

                if (qGet != null)
                {
                    var timeDifference = secondLast - qGet.startTimeInSecond;
                    var priceForOneSecond = (double)oneHourPrice / 3600;
                    var totalPrice = timeDifference * priceForOneSecond;

                    qGet.endTime = Convert.ToDateTime(time);
                    qGet.status = true;
                    qGet.price = totalPrice;
                    qGet.endTimeInSecond = secondLast;

                    db.playings.Attach(qGet);
                    db.Entry(qGet).State = System.Data.Entity.EntityState.Modified;

                    if (Convert.ToBoolean(db.SaveChanges()))
                    {
                        var qGetName = (from a in db.players
                            where a.Id.Equals(qGet.playerId)
                            select a).SingleOrDefault();

                        if (qGetName != null)
                        {
                            var username = qGetName.name + qGetName.lastname;
                            var lastPrice = Convert.ToInt64(qGet.price);
                            new ShowFinish(username, Convert.ToString(qGet.startTime, CultureInfo.InvariantCulture), Convert.ToString(qGet.endTime), Convert.ToString(lastPrice)).Show();
                            Close();
                        }
                        else
                        {
                            var lastPrice = Convert.ToInt64(qGet.price);
                            new ShowFinish("بدون نام", Convert.ToString(qGet.startTime, CultureInfo.InvariantCulture), Convert.ToString(qGet.endTime, CultureInfo.InvariantCulture), Convert.ToString(lastPrice)).Show();
                            Close();
                        }                                               
                    }
                    else
                    {
                        error.Opacity = 1;
                    }
                }
                else
                {
                    error.Opacity = 1;
                }                
            }
        }

        private void RowContextMenu(object sender,EventArgs eventArgs)
        {

        }
    }
}

using System.Windows;
using System.Windows.Input;

namespace GameHall
{
    /// <summary>
    /// Interaction logic for CheckUpList.xaml
    /// </summary>
    public partial class CheckUpList
    {
        public CheckUpList()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
                                 
        }

        private void BtnRemove(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void BtnAdd(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void ShowAdvancedSearchBtn(object sender, MouseButtonEventArgs e)
        {
            new AdvancedSearch().Show();
        }
    }
}

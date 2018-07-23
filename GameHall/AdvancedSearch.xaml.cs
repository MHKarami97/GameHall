using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Ink;
using System.Reflection;

namespace GameHall
{
    /// <summary>
    /// Interaction logic for AdvancedSearch.xaml
    /// </summary>
    public partial class AdvancedSearch
    {
        public AdvancedSearch()
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

        private void SearchBtn(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}

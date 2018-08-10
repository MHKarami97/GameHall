using System;
using System.Windows;
using System.Windows.Forms;
using System.Diagnostics;

namespace GameHall
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        //private const string SampleDocumentFile = "SampleWordDocument.docx";

        static MainWindow()
        {
            IsWindowsThemeEnabled = false;
        }

        public MainWindow()
        {
            InitializeComponent();
            //IconSources.ChangeIconsSet(IconsSet.Modern);

            Loaded += MainWindow_Loaded;
        }

        NotifyIcon _icon = new NotifyIcon();

        public NotifyIcon GetIcon1()
        {
            return _icon;
        }

        public void SetIcon1(NotifyIcon value)
        {
            _icon = value;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //GetIcon1().Icon = Properties.Resources.TelerikWord;
            GetIcon1().Visible = true;

            HourLbl.Content = DateTime.Now.Hour;
            MinLbl.Content = DateTime.Now.Minute;

            System.Windows.Threading.DispatcherTimer time = new System.Windows.Threading.DispatcherTimer();
            time.Tick += NoghteSaat;
            time.Interval = new TimeSpan(0, 0, 0, 1, 0);
            time.Start();
        }

        private void NoghteSaat(object sender, EventArgs e)
        {
            DotTime.Visibility = DotTime.Visibility == Visibility.Hidden ? Visibility.Visible : Visibility.Hidden;
        }


        private void BtnClose(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnNew(object sender, RoutedEventArgs e)
        {
            new NewPatient().Show();
        }

        private void BtnNewUser(object sender, RoutedEventArgs e)
        {
            new AddUser().Show();
        }

        private void OpenSiteBtn(object sender, RoutedEventArgs e)
        {
            Process.Start("https://shop.itarfand.com");
        }

        private void OpenCalculatorBtn(object sender, RoutedEventArgs e)
        {
            try
            {
                var p = new Process {StartInfo = {FileName = "Calc.exe"}};
                p.Start();
            }
            catch (Exception e1)
            {
                System.Windows.MessageBox.Show("Excepton" + e1.Message);
            }
        }

        private void ShowUserListBtn(object sender, RoutedEventArgs e)
        {
            new UserList().Show();
        }

        private void ShowAllCheckUpBtn(object sender, RoutedEventArgs e)
        {
            new CheckUpList().Show();
        }
    }
}

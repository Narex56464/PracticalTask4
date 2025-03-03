using System.Windows;
using WpfApp7.Utilis;
using WpfApp7.View.Pages;

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MyNavigation.MyConnect = MyFrame;

            MyFrame.Navigate(new MainPage());
        }
    }
}

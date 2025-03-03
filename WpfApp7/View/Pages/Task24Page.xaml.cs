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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp7.Utilis;
using WpfApp7.Utilis.Tasks;

namespace WpfApp7.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task24Page.xaml
    /// </summary>
    public partial class Task24Page : Page
    {
        public Task24Page()
        {
            InitializeComponent();
            
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double t = 6.2, b = 1.8;
            Task24 task24 = new Task24(t, b);

            TbA.Text = $"a = {task24.A()}";
            TbX.Text = $"x = {task24.X()}";
            TbY.Text = $"y = {task24.Y()}";
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task25Page());
        }
    }
}

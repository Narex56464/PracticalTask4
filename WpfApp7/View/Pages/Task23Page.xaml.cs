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
    /// Логика взаимодействия для Task23Page.xaml
    /// </summary>
    public partial class Task23Page : Page
    {
        public Task23Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x = 5.2, b = 0.3;
            Task23 task23 = new Task23(x, b);

            TbA.Text = $"a = {task23.A()}";
            TbT.Text = $"t = {task23.T()}";
            TbY.Text = $"y = {task23.Y()}";
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task24Page());
        }
    }
}

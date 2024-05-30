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

namespace NauchKonf_ProskuninMV_05.Pages
{
    /// <summary>
    /// Логика взаимодействия для ZavOtdPage.xaml
    /// </summary>
    public partial class ZavOtdPage : Page
    {
        public ZavOtdPage()
        {
            InitializeComponent();
        }

        private void btnAllSotr_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Pages.SotrPage());
        }

        private void btnOrders_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Pages.AllOrdersPage());
        }

        private void btnSmen_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Pages.SmenPage());
        }
    }
}

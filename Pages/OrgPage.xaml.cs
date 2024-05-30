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
    /// Логика взаимодействия для OrgPage.xaml
    /// </summary>
    public partial class OrgPage : Page
    {
        public OrgPage()
        {
            InitializeComponent();
        }

        private void btnSozdNewOrder_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame = MainFrame;
            Manager.MainFrame.Navigate(new Pages.NewOrderPage());
        }

        private void btnAllOrders_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame = MainFrame;
            Manager.MainFrame.Navigate(new Pages.AllOrdersPage());
        }
    }
}

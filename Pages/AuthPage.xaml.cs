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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void btnVoiti_Click(object sender, RoutedEventArgs e)
        {
            user objUser = DataBaseEntities.GetContext().user.FirstOrDefault(x => x.login == txtLogin.Text && x.password == txtPassword.Password);

            if (objUser != null)
            {
                if (objUser.lastname == "")
                {
                    MessageBox.Show("Вы уволены", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                }

                switch (objUser.userid)
                {
                    case 1:
                        Manager.MainFrame.Navigate(new Pages.OrgPage());
                        break;
                    case 2:
                        Manager.MainFrame.Navigate(new Pages.ZavOtdPage());
                        break;
                    case 3:
                        Manager.MainFrame.Navigate(new Pages.TekniquePage());
                        break;
                }
            }

            else
            {
                MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

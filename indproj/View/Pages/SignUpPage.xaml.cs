using indproj.Model;
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
using static indproj.Core.Corr;

namespace indproj.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class SignUpPage : Page
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore.Navigate(new LoginPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LigmaEntities23 _db = new LigmaEntities23();
                if (string.IsNullOrEmpty(dbLogin1.Text) ||
                    string.IsNullOrEmpty(dbPassword1.Password))
                {
                    MessageBox.Show($"Ошибка ввода данных","Системное сообщение", MessageBoxButton.OK,
                                MessageBoxImage.Error);
                }
                else
                {
                    _db.Users.Add(new User()
                    {
                        Login = dbLogin1.Text,
                        Password = dbPassword1.Password
                    });
                   _db.SaveChanges(); 
                    MessageBox.Show($"Регистрация успешно пройдена");
                    CoreNavigate.MyCore.Navigate(new MainPage());


                    dbLogin1.Text = string.Empty;
                    dbPassword1.Password = string.Empty;
                }
        }
    }
}

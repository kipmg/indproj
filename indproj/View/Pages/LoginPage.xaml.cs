using indproj.Core;
using indproj.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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
    public partial class LoginPage : Page
    {
        
        
        public LoginPage()

        {


            InitializeComponent();

          
        }

       

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {

            {
                if (string.IsNullOrEmpty(dbLogin.Text) ||
                    string.IsNullOrEmpty(dbPassword.Password))
                {
                    MessageBox.Show($"Ошибка ввода данных", "Системное Сообщение", MessageBoxButton.OK, MessageBoxImage.Error);


                }
                else
                {
                    try
                    {
                        User userModel = CoreNavigate.DB.Users.FirstOrDefault(u => u.Login == dbLogin.Text && u.Password == dbPassword.Password);
                        if (userModel != null)
                        {
                            CoreNavigate.MyCore.Navigate(new MainPage());
                            MessageBox.Show($"{userModel.Login} - выполнен успешный вход", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Ошибка ввода данных",
                                "Системное сообщение", MessageBoxButton.OK,
                                MessageBoxImage.Error);
                        }


                    }
                    catch (Exception)
                    {
                        throw;
                    }

                }



            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore.Navigate(new SignUpPage());
        }
    }
}


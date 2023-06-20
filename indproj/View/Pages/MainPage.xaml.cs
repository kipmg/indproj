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
using System.Xml.Linq;
using static indproj.Core.Corr;

namespace indproj.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore.Navigate(new HSC());
        }

        private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore.Navigate(new dawg3());
        }

        private void ButtonBase_OnClick4(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore.Navigate(new dawg2());
        }

        private void ButtonBase_OnClick3(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore.Navigate(new dawg1());
        }

        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore.Navigate(new impr1());
        }

        private void ButtonBase_OnClick6(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore.Navigate(new impr2());
        }

        private void ButtonBase_OnClick8(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore.Navigate(new btlbit1());
        }

        private void ButtonBase_OnClick7(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore.Navigate(new btlbit2());
        }

        private void ButtonBase_OnClick5(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore.Navigate(new Yo());
        }

        private void Button_rndClick(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore.Navigate(new FA69());
        }

        private void Button_rndClick2(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore.Navigate(new btlbit());
        }
        private void Button_rndClick1(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore.Navigate(new impr());
        }
    }
}

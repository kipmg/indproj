using indproj.Core;
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
    /// Логика взаимодействия для HSC.xaml
    /// </summary>
    public partial class HSC : Page
    {
        public HSC()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore.Navigate(new MainPage());
        }
        
       

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void Chip_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore.Navigate(new FA69());
        }
    }
}
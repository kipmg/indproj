﻿using System;
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
    /// Логика взаимодействия для btlbit.xaml
    /// </summary>
    public partial class btlbit : Page
    {
        public btlbit()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore.Navigate(new MainPage());
        }
    }
}
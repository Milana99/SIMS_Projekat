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
using System.Windows.Shapes;

namespace Bolnica.xaml_window.Doctor
{
    /// <summary>
    /// Interaction logic for DrugListForVerifyCancel.xaml
    /// </summary>
    public partial class DrugListForVerifyCancel : Window
    {
        public DrugListForVerifyCancel()
        {
            InitializeComponent();
        }

        private void Button_Click_OK(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Canel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

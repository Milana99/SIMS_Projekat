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

namespace Bolnica.xaml_window.Manager
{
    /// <summary>
    /// Interaction logic for RenovationGeneral.xaml
    /// </summary>
    public partial class RenovationGeneral : Window
    {
        RenovationAdd ra;
        public RenovationGeneral()
        {
            InitializeComponent();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            ra = new RenovationAdd();
            ra.Show();
            this.Close();
        }

        private void Button_Click_OK(object sender, RoutedEventArgs e)
        {
            ra = new RenovationAdd();
            ra.Show();
            this.Close();
        }
    }
}

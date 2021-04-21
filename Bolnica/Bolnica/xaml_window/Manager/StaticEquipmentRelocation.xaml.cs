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
    /// Interaction logic for StaticEquipmentRelocation.xaml
    /// </summary>
    public partial class StaticEquipmentRelocation : Window
    {
        public StaticEquipment se;
        public StaticEquipmentRelocation(StaticEquipment s)
        {
            InitializeComponent();
            se = s;
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            se.control.ChangeRoom(int.Parse(lbuIDStaticEq.Content.ToString()), int.Parse(cbuRoomStatic.Text));
            se.Load();
            this.Close();
        }
    }
}

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
using System.Windows.Shapes;

namespace Bolnica.xaml_window.Manager
{
    /// <summary>
    /// Interaction logic for DynamicEquipmentIncrease.xaml
    /// </summary>
    /// 
    
    public partial class DynamicEquipmentIncrease : Window
    {

        public DynamicEquipment de;
        public int Quantity;
        public DynamicEquipmentIncrease(DynamicEquipment d, int oldQuantity)
        {
            InitializeComponent();
            de = d;
            Quantity = oldQuantity;
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            Quantity += int.Parse(tbiQuantityDynamicEq.Text);
            de.control.UpdateDynamicEquipment(int.Parse(lbiIDDynamicEq.Content.ToString()), Quantity, lbiNameDynamicEq.Content.ToString());
            de.Load();
            this.Close();
        }
    }
}

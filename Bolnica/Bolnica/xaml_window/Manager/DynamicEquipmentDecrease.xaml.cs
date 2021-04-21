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
    /// Interaction logic for DynamicEquipmentDecrease.xaml
    /// </summary>
    public partial class DynamicEquipmentDecrease : Window
    {
        public DynamicEquipment de;
        public int Quantity;
        public DynamicEquipmentDecrease(DynamicEquipment d, int oldQuantity)
        {
            InitializeComponent();
            Quantity = oldQuantity;
            de = d;
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            if (int.Parse(tbdQuantityDynamicEq.Text) > Quantity)
            {
                MessageBox.Show("Uneta količina je veća od raspoložive");

            }
            else
            {
                Quantity -= int.Parse(tbdQuantityDynamicEq.Text);
                de.control.UpdateDynamicEquipment(int.Parse(lbdIDDynamicEq.Content.ToString()), Quantity, lbdNameDynamicEq.Content.ToString());

                de.Load();
                this.Close();
            }
        }
    }
}

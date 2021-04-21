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
    /// Interaction logic for DynamicEquipment.xaml
    /// </summary>
    public partial class DynamicEquipment : Window
    {
        ListEquipment le;
        DynamicEquipmentCreate dec;
        DynamicEquipmentDecrease ded;
        DynamicEquipmentIncrease dei;
        public DynamicEquipment()
        {
            InitializeComponent();
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            le = new ListEquipment();
            le.Show();
            this.Close();
        }

        private void Button_Click_Create(object sender, RoutedEventArgs e)
        {
            dec = new DynamicEquipmentCreate();
            dec.Show();
        }

        private void Button_Click_Decrease(object sender, RoutedEventArgs e)
        {
            ded = new DynamicEquipmentDecrease();
            ded.Show();
            
        }

        private void Button_Click_Increase(object sender, RoutedEventArgs e)
        {
            dei = new DynamicEquipmentIncrease();
            dei.Show();
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {

        }
    }
}

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
    /// Interaction logic for DynamicEquipmentCreate.xaml
    /// </summary>
    public partial class DynamicEquipmentCreate : Window
    {

        public DynamicEquipment de;
        public DynamicEquipmentCreate(DynamicEquipment d)
        {
            InitializeComponent();
            de = d;
            lbIDDynamicEq.Content = de.control.dynamicEquipmentService.dynamicEquipmentRepository.next_id.ToString();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            de.control.CreateDynamicEquipment(int.Parse(lbIDDynamicEq.Content.ToString()), int.Parse(tbQuantityDynamicEq.Text), tbNameDynamicEq.Text);
            de.Load();
            this.Close();
        }
    }
}

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

        public List<Model.DynamicEquipment> equipments;
        public Controller.DynamicEquipmentController control;
        public DynamicEquipment()
        {
            InitializeComponent();
            control = new Controller.DynamicEquipmentController();
            equipments = new List<Model.DynamicEquipment>();
            Load();
        }

        public void Load()
        {
            lvDataBindingDynamicEq.Items.Clear();

            equipments = control.GetAllDynamicEquipments();

            foreach (Model.DynamicEquipment de in equipments)
            {
                
                lvDataBindingDynamicEq.Items.Add(de);
            }
        }
        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            le = new ListEquipment();
            le.Show();
            this.Close();
        }

        private void Button_Click_Create(object sender, RoutedEventArgs e)
        {
            dec = new DynamicEquipmentCreate(this);
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
            Model.DynamicEquipment selected =
                (Model.DynamicEquipment)lvDataBindingDynamicEq.SelectedItems[0];
            dei.lbiIDDynamicEq.Content = selected.DynamicEquipmentId.ToString();
            dei.lbiNameDynamicEq.Content = selected.DynamicEquipmentName;

            dei.Show();
            

        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            Model.DynamicEquipment selected = (Model.DynamicEquipment)lvDataBindingDynamicEq.SelectedItems[0];
            control.DeleteDynamicEquipment(selected.DynamicEquipmentId);
            Load();
        }
    }
}

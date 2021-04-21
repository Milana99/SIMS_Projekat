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
    /// Interaction logic for StaticEquipment.xaml
    /// </summary>
    public partial class StaticEquipment : Window
    {
        ListEquipment le;
        StaticEquipmentCreate sec;
        StaticEquipmentRelocation ser;
        StaticEquipmentUpdate seu;

        public List<Model.StaticEquipment> equipments;
        public Controller.StaticEquipmentController control;
        public StaticEquipment()
        {
            InitializeComponent();
            equipments = new List<Model.StaticEquipment>();
            control = new Controller.StaticEquipmentController();
            Load();
        }

        public void Load()
        {
            lvDataBindingStaticEq.Items.Clear();

            equipments = control.GetAllEquipment();

            foreach (Model.StaticEquipment ste in equipments)
            {
                Console.WriteLine(ste.StaticEquipmentId);
                lvDataBindingStaticEq.Items.Add(ste);
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
            sec = new StaticEquipmentCreate(this);
            sec.Show();
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            Model.StaticEquipment selected = (Model.StaticEquipment)lvDataBindingStaticEq.SelectedItems[0];
            control.DeleteStaticEquipment(selected.StaticEquipmentId);
            Load();
        }

        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {
            Model.StaticEquipment selected = (Model.StaticEquipment)lvDataBindingStaticEq.SelectedItems[0];
            seu = new StaticEquipmentUpdate(this);
            seu.lbuIDStaticEq.Content = selected.StaticEquipmentId;
            seu.tbStaticDescription.Text = selected.DescriptionStaticEquipment;
            seu.tbuName.Text = selected.NameStaticEquipment;
            seu.lbuRoomStatic.Content = selected.roomStaticEquipment.RoomId;
            seu.Show();
        }

        private void Button_Click_Relocation(object sender, RoutedEventArgs e)
        {
            ser = new StaticEquipmentRelocation();
            ser.Show();
        }
    }
}

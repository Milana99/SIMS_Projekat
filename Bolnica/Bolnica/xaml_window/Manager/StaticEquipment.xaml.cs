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
            LoadEqupiment();
            LoadRooms();
        }

        public void LoadEqupiment()
        {
            lvDataBindingStaticEq.Items.Clear();

            equipments = control.GetAllEquipment();

            foreach (Model.StaticEquipment ste in equipments)
            {
                Console.WriteLine(ste.StaticEquipmentId);
                lvDataBindingStaticEq.Items.Add(ste);
            }
            
        }
        public void LoadRooms()
        {
            
            Controller.RoomController roomController = new Controller.RoomController();
            List<Model.Room> rooms = roomController.GetAllRooms();
            foreach (Model.Room room in rooms)
            {
                cbRooms.Items.Add(room.RoomId);
            }
            cbRooms.Items.Add("All");
            cbRooms.SelectedItem = "All";
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
            LoadEqupiment();
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
            Model.StaticEquipment selected = (Model.StaticEquipment)lvDataBindingStaticEq.SelectedItems[0];
            
            Controller.RoomController rc = new Controller.RoomController();
            ser = new StaticEquipmentRelocation(this);

            List<Model.Room> rooms = rc.GetAllRooms();
            foreach (Model.Room r in rooms)
            {
                ser.cbuRoomStatic.Items.Add(r.RoomId);
            }
            
            ser.lbuIDStaticEq.Content = selected.StaticEquipmentId;
            ser.lbuStaticDescription.Content = selected.DescriptionStaticEquipment;
            ser.lbuName.Content = selected.NameStaticEquipment;
            ser.cbuRoomStatic.Text = selected.roomStaticEquipment.RoomId.ToString();
            ser.Show();
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(tbSearch.Text!= "Pretraga inventara...")
            {
                Search(tbSearch.Text);
            }
            
        }
        

        private void Search(string searchedWord)
        {
            lvDataBindingStaticEq.Items.Clear();
            foreach (Model.StaticEquipment equipment in equipments)
            {
                if ((equipment.NameStaticEquipment.Contains(searchedWord))||(equipment.DescriptionStaticEquipment.Contains(searchedWord)))
                {
                    lvDataBindingStaticEq.Items.Add(equipment);
                }
            }
        }

        private void tbSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            if(tbSearch.Text == "Pretraga inventara...")
            {
                tbSearch.Clear();
            }
            tbSearch.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void tbSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            tbSearch.Foreground = new SolidColorBrush(Colors.Gray);
        }
        private List<Model.StaticEquipment> LoadEquipmentsForFiltration()
        {
            List<Model.StaticEquipment> staticEquipments = new List<Model.StaticEquipment>();
            for (int i = 0; i < lvDataBindingStaticEq.Items.Count; i++)
            {
                Model.StaticEquipment staticEquipment = (Model.StaticEquipment)lvDataBindingStaticEq.Items[i];
                staticEquipments.Add(staticEquipment);
            }
            return staticEquipments;
        }
        private void FiltrateEquipments(List<Model.StaticEquipment> staticEquipments)
        {
            lvDataBindingStaticEq.Items.Clear();
            foreach (Model.StaticEquipment equipment in staticEquipments)
            {
                if (equipment.roomStaticEquipment.RoomId == int.Parse(cbRooms.SelectedItem.ToString()))
                {
                    lvDataBindingStaticEq.Items.Add(equipment);
                }
            }
        }
        private void cbRooms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbRooms.SelectedItem.ToString() != "All" && cbRooms.Text != "")
            {
                List<Model.StaticEquipment> staticEquipments = LoadEquipmentsForFiltration();
                FiltrateEquipments(staticEquipments);
            }
            else
            {
                LoadEqupiment();
            }
            
        }
    }
}

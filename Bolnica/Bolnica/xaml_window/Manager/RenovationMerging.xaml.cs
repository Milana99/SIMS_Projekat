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
    /// Interaction logic for RenovationMerging.xaml
    /// </summary>
    public partial class RenovationMerging : Window
    {
        Controller.RoomController roomController;
        public RenovationMerging()
        {
            InitializeComponent();
            roomController = new Controller.RoomController();
            loadRooms();
            loadRoomTypes();
        }

        public void loadRoomTypes()
        {
            cbRoomType.Items.Add("OperationRoom");
            cbRoomType.Items.Add("HospitalRoom");
            cbRoomType.Items.Add("Ordination");
        }
        public void loadRooms()
        {
            List<Model.Room> rooms = roomController.GetAllRooms();
            foreach(Model.Room room in rooms)
            {
                cbRooms.Items.Add(room.RoomId);
            }
        }
        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            var renovation_add = new RenovationAdd();
            renovation_add.Show();
            this.Close();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            var renovation_add = new RenovationAdd();
            renovation_add.Show();
            this.Close();
        }

        private void btMerge_Click(object sender, RoutedEventArgs e)
        {
            Model.Room room = roomController.GetByIdRoom(int.Parse(cbRooms.SelectedItem.ToString()));
            if (checkFloor(room.Floor))
            {
                lvDataBindingRooms.Items.Add(room);
                LoadArea();
                LoadFloor();
            }
        }
        private bool checkFloor(int Floor)
        {
            if (lvDataBindingRooms.Items.IsEmpty)
            {
                return true;
            }
            else
            {
                Model.Room FirstRoom = (Model.Room)lvDataBindingRooms.Items[0];
                if(Floor != FirstRoom.Floor)
                {
                    MessageBox.Show("Mogu se spajati samo sobe koje su na istom spratu");
                    return false;
                }
            }
            return true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lvDataBindingRooms.Items.Remove(lvDataBindingRooms.SelectedItem);
            LoadArea();
            LoadFloor();
        }
        private void LoadArea()
        {
            double area = 0;
            for(int i = 0; i<lvDataBindingRooms.Items.Count; i++)
            {
                Model.Room room = (Model.Room)lvDataBindingRooms.Items[i];
                area += room.Area;
            }
            lbArea.Content = area;
        }
        private void LoadFloor()
        {
            if (lvDataBindingRooms.Items.IsEmpty)
            {
                lbuFloor.Content = "";
            }
            else
            {
                lbuFloor.Content = ((Model.Room)lvDataBindingRooms.Items[0]).Floor;
            }
        }
    }
}

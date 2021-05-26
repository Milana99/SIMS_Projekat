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
    /// Interaction logic for RenovationDivision.xaml
    /// </summary>
    public partial class RenovationSeparation : Window
    {
        Controller.RoomController roomController;
        public RenovationSeparation()
        {
            InitializeComponent();
            roomController = new Controller.RoomController();
            LoadRooms();
        }
        public void LoadRooms()
        {
            foreach(Model.Room room in roomController.GetAllRooms())
            {
                cbRooms.Items.Add(room.RoomId);
            }
        }
        
        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            DeleteRoom();
            var renovation_add = new RenovationAdd();
            renovation_add.Show();
            this.Close();
        }
        private void DeleteRoom()
        {
            if (int.Parse(lbArea.Content.ToString()) == 0)
            {
                roomController.DeleteRoom(int.Parse(cbRooms.SelectedItem.ToString()));
            }
        }
        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            var renovation_add = new RenovationAdd();
            renovation_add.Show();
            this.Close();
        }

        private void Button_Click_Add_Room(object sender, RoutedEventArgs e)
        {
            var renovation_division_add_room = new RenovationSeparationRoomAdd(this, roomController);
            renovation_division_add_room.Show();
            this.Hide();
        }

        private void cbRooms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadArea();
        }
        public void LoadArea()
        {
            Model.Room room = roomController.GetByIdRoom(int.Parse(cbRooms.SelectedItem.ToString()));
            lbArea.Content = room.Area;
            lbFloor.Content = room.Floor;
        }
    }
}

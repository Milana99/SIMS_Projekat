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
    /// Interaction logic for CreateRoom.xaml
    /// </summary>
    public partial class CreateRoom : Window
    {
        public RoomList roomList;
        public CreateRoom(RoomList rl)
        {
            InitializeComponent();
            cbRoomType.Items.Add("Ordination");
            cbRoomType.Items.Add("HospitalRoom");
            cbRoomType.Items.Add("OperationRoom");
            cbRoomType.Text = "Ordination";
            roomList = rl;
            lbID.Content = roomList.manager.rfs.next_roomID.ToString();

        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            Model.Room room = new Model.Room(roomList.manager.rfs.next_roomID, tbDescription.Text,
                int.Parse(tbFloor.Text), double.Parse(tbArea.Text),
                (Model.RoomType)Enum.Parse(typeof(Model.RoomType), cbRoomType.Text));
            roomList.manager.rfs.next_roomID++;
            roomList.manager.AddRoom(room);
            roomList.Load();
            this.Close();
        }
    }
}

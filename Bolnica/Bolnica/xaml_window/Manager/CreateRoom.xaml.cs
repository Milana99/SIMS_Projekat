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
using System.ComponentModel;

namespace Bolnica.xaml_window.Manager
{
    /// <summary>
    /// Interaction logic for CreateRoom.xaml
    /// </summary>
    public partial class CreateRoom : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public RoomList roomList;
        private string description;
        private int floor;
        private double area;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value != description)
                {
                    description = value;
                    OnPropertyChanged("Description");
                }

            }
        }
        public int Floor
        {

            get
            {
                return floor;
            }
            set
            {
                if (value != floor)
                {
                    floor = value;
                    OnPropertyChanged("Floor");
                }

            }
        }
        public double Area
        {

            get
            {
                return area;
            }
            set
            {
                if (value != area)
                {
                    area = value;
                    OnPropertyChanged("Area");
                }

            }
        }
        public CreateRoom(RoomList rl)
        {
            InitializeComponent();
            this.DataContext = this;
            cbRoomType.Items.Add("Ordination");
            cbRoomType.Items.Add("HospitalRoom");
            cbRoomType.Items.Add("OperationRoom");
            cbRoomType.Text = "Ordination";
            roomList = rl;
            lbID.Content = roomList.control.roomService.roomRepository.next_roomID.ToString();

        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
           
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da izađete?", "Zdravo", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
            {
                var room_list = new RoomList();
                room_list.Show();
                this.Close();
            }
            return;
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            if (tbDescription.Text == "" || tbDescription.Text == null || tbArea.Text == "" || tbArea.Text == null
                || tbFloor.Text == "" || tbFloor.Text == null || cbRoomType.Text=="")
            {
                MessageBox.Show("Niste popunili sva polja!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                var room_list = new RoomList();
                Model.Room room = new Model.Room(roomList.control.roomService.roomRepository.next_roomID, tbDescription.Text,
                    int.Parse(tbFloor.Text), double.Parse(tbArea.Text),
                    (Model.RoomType)Enum.Parse(typeof(Model.RoomType), cbRoomType.Text));
                roomList.control.roomService.roomRepository.next_roomID++;
                roomList.control.CreateRoom(room);
                roomList.Load();
                room_list.Show();
                this.Close();
                MessageBox.Show("Uspešno ste kreirali salu!", "Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }
    }
}

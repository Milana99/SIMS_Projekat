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
    /// Interaction logic for RenovationMerging.xaml
    /// </summary>
    public partial class RenovationMerging : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        Controller.RoomController roomController;
        private string start;
        private string end;
        private string description;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        public string Start
        {
            get
            {
                return start;
            }
            set
            {
                if (value != start)
                {
                    start = value;
                    OnPropertyChanged("Start");
                }

            }
        }
        public string End
        {
            get
            {
                return end;
            }
            set
            {
                if (value != end)
                {
                    end = value;
                    OnPropertyChanged("End");
                }

            }
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
        public RenovationMerging()
        {
            InitializeComponent();
            this.DataContext = this;
            roomController = new Controller.RoomController();
            loadRooms();
            loadRoomTypes();
            lbuID.Content = roomController.getNextId();
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
        public void LoadEquipmentFromRoom(int roomId)
        {
            Controller.StaticEquipmentController equipmentController = new Controller.StaticEquipmentController();
            equipmentController.changeRoomFromRoom(int.Parse(lbuID.Content.ToString()), roomId);
        }
        public void CreateRoom()
        {
            Model.Room room = new Model.Room(int.Parse(lbuID.Content.ToString()), tbuDescription.Text,
                int.Parse(lbuFloor.Content.ToString()), double.Parse(lbArea.Content.ToString()), 
                (Model.RoomType)Enum.Parse(typeof(Model.RoomType), cbRoomType.Text));
            roomController.CreateRoom(room);
        }
        private void deleteAllRooms()
        {
            for (int i = 0; i < lvDataBindingRooms.Items.Count; i++)
            {
                Model.Room room = (Model.Room)lvDataBindingRooms.Items[i];
                LoadEquipmentFromRoom(room.RoomId);
                roomController.DeleteRoom(room.RoomId);
            }
        }
        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            if (tbuDescription.Text == "" || tbuDescription.Text == null || tbEndTime.Text == "" || tbEndTime.Text == null
             || tbStartTime.Text == "" || tbStartTime.Text == null || dpDateRenovationEnd.Text == "" || dpDateRenovationEnd.Text == null
             || dpDateRenovationStart.Text == "" || dpDateRenovationStart.Text == null || cbRooms.Text == "" || cbRooms.Text=="" || cbRooms.Text==null 
             || cbRoomType.Text==null || cbRoomType.Text=="")
            {
                MessageBox.Show("Niste popunili sva polja!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                CreateRoom();
                createRenovation();
                deleteAllRooms();
                var renovation_add = new RenovationAdd();
                renovation_add.Show();
                this.Close();
                MessageBox.Show("Uspešno ste zakazali spajanje sala!", "Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        private void createRenovation()
        {
            Controller.BasicRenovationController basicRenovationController = new Controller.BasicRenovationController();
            basicRenovationController.GetAllRenovations();
            Model.BasicRenovation basicRenovation = new Model.BasicRenovation(basicRenovationController.renovationService.renovationRepository.getNextRenovationId(),
                int.Parse(lbuID.Content.ToString()), DateTime.Parse(dpDateRenovationStart.Text.ToString() + " " + tbStartTime.Text.ToString()),
                DateTime.Parse(dpDateRenovationEnd.Text.ToString() + " " + tbEndTime.Text.ToString()), "Merging room");
            basicRenovationController.CreateRenovation(basicRenovation);
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da izađete?", "Zdravo", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
            {
                var renovation_add = new RenovationAdd();
                renovation_add.Show();
                this.Close();
            }
            return;
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

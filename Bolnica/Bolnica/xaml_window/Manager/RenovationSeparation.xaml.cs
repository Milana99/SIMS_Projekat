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
    /// Interaction logic for RenovationDivision.xaml
    /// </summary>
    public partial class RenovationSeparation : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        Controller.RoomController roomController;
        private string start;
        private string end;
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
        public RenovationSeparation()
        {
            InitializeComponent();
            this.DataContext = this;
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
            if (tbEndTime.Text == "" || tbEndTime.Text == null
             || tbStartTime.Text == "" || tbStartTime.Text == null || dpDateRenovationEnd.Text == "" || dpDateRenovationEnd.Text == null
             || dpDateRenovationStart.Text == "" || dpDateRenovationStart.Text == null || cbRooms.Text == "" || cbRooms.Text == null
             )
            {
                MessageBox.Show("Niste popunili sva polja!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                DeleteRoom();
                var renovation_add = new RenovationAdd();
                renovation_add.Show();
                this.Close();
                MessageBox.Show("Uspešno ste zakazali deljenje sala!", "Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
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
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da izađete?", "Zdravo", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
            {
                var renovation_add = new RenovationAdd();
                renovation_add.Show();
                this.Close();
            }
            return;
        }

        private void Button_Click_Add_Room(object sender, RoutedEventArgs e)
        {
            if(cbRooms.Text=="" || cbRooms.Text==null)
            {
                MessageBox.Show("Nije moguće podeliti salu ako je pre toga niste selektovali!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
                
            }
            else
            {
                var renovation_division_add_room = new RenovationSeparationRoomAdd(this, roomController);
                renovation_division_add_room.Show();
                this.Hide();
                
            }

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

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
    /// Interaction logic for RenovationGeneral.xaml
    /// </summary>
    public partial class RenovationGeneral : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        RenovationAdd addRenovation;
        public Controller.RoomController roomController;
        public Controller.BasicRenovationController renovationController;
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
        public RenovationGeneral(RenovationAdd renovationAdd)
        {
            InitializeComponent();
            this.DataContext = this;
            roomController = new Controller.RoomController();
            
            addRenovation = renovationAdd;
            renovationController = addRenovation.renovationController;
            LoadRooms();
        }
        public void LoadRooms()
        {
            List<Model.Room> rooms = roomController.GetAllRooms();
            foreach(Model.Room room in rooms)
            {
                cbRooms.Items.Add(room.RoomId) ;
            }
        }
        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da izađete?", "Zdravo", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
            {
                addRenovation.Show();
                this.Close();
            }
            return;
        }

        private Model.BasicRenovation CreateRenovation()
        {
            Model.BasicRenovation renovation = new Model.BasicRenovation(renovationController.renovationService.renovationRepository.getNextRenovationId(),
                int.Parse(cbRooms.Text), DateTime.Parse(dpDateRenovationStart.Text + " " + tbStartTime.Text), DateTime.Parse(dpDateRenovationEnd.Text + " " + tbEndTime.Text),
                tbDescriptionRenovation.Text);
            return renovation;
        }
        private void Button_Click_OK(object sender, RoutedEventArgs e)
        {
            if (tbDescriptionRenovation.Text == "" || tbDescriptionRenovation.Text == null || tbEndTime.Text == "" || tbEndTime.Text == null
              || tbStartTime.Text == "" || tbStartTime.Text == null || dpDateRenovationEnd.Text == "" || dpDateRenovationEnd.Text == null
              || dpDateRenovationStart.Text == "" || dpDateRenovationStart.Text == null || cbRooms.Text=="")
            {
                MessageBox.Show("Niste popunili sva polja!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {

                Model.BasicRenovation renovation = CreateRenovation();
                if (renovationController.renovationService.IsRoomFree(renovation.StartTime, renovation.EndTime, renovation.room.RoomId))
                {
                    renovationController.CreateRenovation(renovation);
                    addRenovation.Show();
                    addRenovation.RenovationList.LoadAllRenovations();
                    this.Close();
                    MessageBox.Show("Uspešno ste zakazali osnovno renoviranje!", "Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Soba nije slobodna u izabranom terminu");
                }
            }
            
        }
    }
}

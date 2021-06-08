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


namespace Bolnica.xaml_window.Doctor
{
    /// <summary>
    /// Interaction logic for CreateExaminatio.xaml
    /// </summary>
    public partial class CreateExamination : Window, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        DoctorHome DoctorHome;
        Controller.RoomController RoomController;
        Controller.PatientController patientController;
        CreateExaminationInventary cei;
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

        public CreateExamination(DoctorHome DoctorHome)
        {
            InitializeComponent();
            this.DataContext = this;
            this.DoctorHome = DoctorHome;
            RoomController = new Controller.RoomController();
            patientController = new Controller.PatientController();
            LoadPatients();
        }
        private void LoadPatients()
        {
            List<Model.Patient> patients = patientController.GetAllPatients();
            foreach(Model.Patient patient in patients)
            {
                cbPatient.Items.Add(patient.User.Username);
            }
            cbPatient.SelectedItem = "Djordje71";
        }

        private void btnDialogCancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da izađete?", "Zdravo", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
                this.Close();
            return;
        }

        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            if(tbEndTime.Text=="" || tbStartTime.Text=="" || cbPatient.Text=="" || cbPatient.Text==null || cbRoom.Text=="" || cbRoom.Text == null || DatePick.Text=="Select a date")
            {
                MessageBox.Show("Niste popunili sva polja!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else {
                Model.Examination ex = new Model.Examination(DoctorHome.ExaminationControl.examinationService.examinationRepository.next_id++,
                    Convert.ToDateTime(DatePick.Text + " " + tbStartTime.Text), Convert.ToDateTime(DatePick.Text + " " + tbEndTime.Text),
                    "Milana123", cbPatient.Text, int.Parse(cbRoom.Text), GetExaminationType());
                DoctorHome.ExaminationControl.examinationService.examinationRepository.next_id++;
                Boolean b = DoctorHome.ExaminationControl.CreateExamination(ex);
                if (b == true)
                {
                    DoctorHome.LoadAll();
                    MessageBox.Show("Uspešno ste dodali resurs!", "Uspešno izvršeno!", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Izabrani termin je zauzet", "Upozorenje", MessageBoxButton.OK,MessageBoxImage.Information);
                }
            }
        }

        private Model.ExaminationType GetExaminationType()
        {
            if (rbEmargncyOperation.IsChecked == true)
            {
                return Model.ExaminationType.Emmergency;
            }
            else if (rbOperation.IsChecked == true)
            {
                return Model.ExaminationType.Surgery;
            }
            else if(rbExamination.IsChecked == true)
            {
                return Model.ExaminationType.Regular;
            }
            else
            {
                return Model.ExaminationType.Specialistic;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            List<Model.Room> rooms = RoomController.roomService.GetAllRoomsByType(Model.RoomType.OperationRoom);
            FillRooms(rooms);
            
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            List<Model.Room> rooms = RoomController.roomService.GetAllRoomsByType(Model.RoomType.Ordination);
            FillRooms(rooms);
        }

        private void FillRooms(List<Model.Room> rooms)
        {
            cbRoom.Items.Clear();
            foreach (Model.Room room in rooms)
            {
                cbRoom.Items.Add(room.RoomId);
            }
        }

        private void cbRoom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void Button_Click_Inventary(object sender, RoutedEventArgs e)
        {
            if(cbRoom.Text == null || cbRoom.Text=="")
            {
                MessageBox.Show("Selektujte sobu pa pogledajte inventar!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                cei = new CreateExaminationInventary(int.Parse(cbRoom.Text));
                cei.Show();
            }
            
        }
    }
}

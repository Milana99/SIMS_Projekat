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

namespace Bolnica.xaml_window.Doctor
{
    public partial class InstructionsForHospitalTreatment : Window
    {
        Controller.RoomController roomController;
        public InstructionsForHospitalTreatment()
        {
            InitializeComponent();
            roomController = new Controller.RoomController();
            LoadRooms();
        }
        private void LoadRooms()
        {
            List<Model.Room> rooms = roomController.GetAllRooms();
            foreach(Model.Room room in rooms)
            {
                if(room.RoomType == Model.RoomType.HospitalRoom)
                {
                    cbRoom.Items.Add(room.RoomId);
                }
                
            }
        }
        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            Controller.StaticEquipmentController staticEquipmentController = new Controller.StaticEquipmentController();
            if (dtStart.Text=="" || dtStart.Text==null||dtEnd.Text==""||dtEnd.Text==null)
            {
                MessageBox.Show("Niste popunili sva polja!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else {
                MessageBox.Show("Uspešno ste kreirali uput za bolničko lečenja!", "Uspešno izvršeno!", MessageBoxButton.OK, MessageBoxImage.Information);

                AddInstructionForHospitalTreatment();
                this.Close();
            }
        }
        private void AddInstructionForHospitalTreatment()
        {
            Controller.InstructionsForHospitalTreatmentController instructionsController = new Controller.InstructionsForHospitalTreatmentController();
            instructionsController.GetAllInstructionsForHospitalTreatment();
            Model.InstructionsForHospitalTreatment instructionsTreatment = new Model.InstructionsForHospitalTreatment(instructionsController.getNextId(),
                lbPatient.Content.ToString(), int.Parse(cbRoom.SelectedItem.ToString()),
                int.Parse(cbBed.SelectedItem.ToString()), DateTime.Parse(dtStart.Text), DateTime.Parse(dtEnd.Text));
            instructionsController.CreateInstructionsForHospitalTreatment(instructionsTreatment);
            ReserveBed();
        }
        private void ReserveBed()
        {
            Controller.StaticEquipmentController staticEquipmentController = new Controller.StaticEquipmentController();
            Model.StaticEquipment staticEquipment = staticEquipmentController.GetOneStaticEquipment(int.Parse(cbBed.SelectedItem.ToString()));
            staticEquipment.free = false;
            staticEquipmentController.UpdateStaticEquipment(staticEquipment.StaticEquipmentId, staticEquipment.DescriptionStaticEquipment,
                staticEquipment.NameStaticEquipment, staticEquipment.free);
        }
        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da izađete?", "Zdravo", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
                this.Close();
            return;
        }

        private void cbRoom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadBeds();
        }
        private void LoadBeds()
        {
            Controller.StaticEquipmentController staticEquipmentController = new Controller.StaticEquipmentController();
            List<Model.StaticEquipment> staticEquipments = staticEquipmentController.GetAllStaticEquipmentForRoom(int.Parse(cbRoom.SelectedItem.ToString()));
            cbBed.Items.Clear();
            foreach (Model.StaticEquipment staticEquipment in staticEquipments)
            {
                if (staticEquipment.NameStaticEquipment == "Krevet" && staticEquipment.free)
                {
                    cbBed.Items.Add(staticEquipment.StaticEquipmentId);
                }
            }
        }

    }
}

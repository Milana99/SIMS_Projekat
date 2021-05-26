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
    /// <summary>
    /// Interaction logic for DoctorHome.xaml
    /// </summary>
    public partial class DoctorHome : Window
    {
       public MainWindow MainWindow;
        ExaminationUpdate ExaminationUpdate;
        CreateExamination CreateExamination;
        MedicalRecordDoctor MedicalRecordDoctor;

        public Model.Doctor doctor;
        public Controller.ExaminationController ExaminationControl;
        public List<Model.Examination> examinations;
        public DoctorHome()
        {
            InitializeComponent();
            ExaminationControl = new Controller.ExaminationController();
            LoadAll();
            
        }

        public void LoadAll()
        {
            lvDataBinding.Items.Clear();

            examinations = ExaminationControl.GetAllExaminations();

            foreach (Model.Examination ex in examinations)
            {
                lvDataBinding.Items.Add(ex);
            }
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            Model.Examination selected = (Model.Examination)lvDataBinding.SelectedItems[0];
            ExaminationControl.DeleteExamination(selected.ExaminationId);
            LoadAll();
            MessageBox.Show("Uspešno ste izbrisali termin", "Uspešno!");
        }

        private void Button_Click_Create(object sender, RoutedEventArgs e)
        {
            CreateExamination = new CreateExamination(this);
            CreateExamination.Show();
            
        }

        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {
            ExaminationUpdate = new ExaminationUpdate(this);
            ExaminationUpdate.Show();
            Model.Examination selected = (Model.Examination)lvDataBinding.SelectedItems[0];

            ExaminationUpdate.lbuID.Content = (selected.ExaminationId.ToString());
            ExaminationUpdate.lbuPatient.Content = (selected.patient.User.Username);
            String[] StartDateTime = selected.StartTime.ToString().Split(' ');
            String[] EndDateTime = selected.EndTime.ToString().Split(' ');
            ExaminationUpdate.tbuStartTime.Text = StartDateTime[1];
            ExaminationUpdate.tbuEndTime.Text = EndDateTime[1];
            ExaminationUpdate.DatePick.Text = StartDateTime[0];
            ExaminationUpdate.cbRoom.Items.Add(selected.room.RoomId);
            ExaminationUpdate.cbRoom.SelectedItem = selected.room.RoomId;
        }

        private void Doctor_Logout(object sender, RoutedEventArgs e)
        {
            MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }

        private void Button_Click_Patient(object sender, RoutedEventArgs e)
        {
            MedicalRecordDoctor = new MedicalRecordDoctor(this);
            MedicalRecordDoctor.Show();
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            var dl = new DrugList();
            dl.Show();
            this.Close();
        }

        private void dpDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

            List<Model.Examination> examinations = ExaminationControl.GetAllExaminations();
            lvDataBinding.Items.Clear();
            foreach(Model.Examination examination in examinations)
            {
                string[] DateAndTime = examination.StartTime.ToString().Split(' ');
                Console.WriteLine(DateAndTime[0]);
                if (DateAndTime[0] == dpDate.Text.ToString())
                {
                    lvDataBinding.Items.Add(examination);
                }
            }
        }

        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {

        }

        private void ListViewItem_Selected_hospital(object sender, RoutedEventArgs e)
        {
            var hospital_treatment = new HospitalTreatment();
            hospital_treatment.Show();
            this.Close();
        }
    }
}

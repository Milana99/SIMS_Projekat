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
    /// Interaction logic for SpeialistExamination.xaml
    /// </summary>
    
    public partial class InstructionsForSpecialistExamination : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        MedicalRecordDoctor MedicalRecordDoctor;
        public Controller.InstrucitonsForSpecialisticExaminationController SpecialisticExaminationController;
        private string spec;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        public string Spec
        {
            get
            {
                return spec;
            }
            set
            {
                if (value != spec)
                {
                    spec = value;
                    OnPropertyChanged("Spec");
                }

            }
        }
        public InstructionsForSpecialistExamination(MedicalRecordDoctor medicalRecord)
        {
            InitializeComponent();
            this.DataContext = this;
            MedicalRecordDoctor = medicalRecord;
            LoadSpecialist();
            lblPatientsName.Content = MedicalRecordDoctor.lbuUsernamePatient.Content;
            SpecialisticExaminationController = new Controller.InstrucitonsForSpecialisticExaminationController();
        }

        

        public void LoadSpecialist()
        {
            cbSpecialist.Items.Add("Grgeč");
            cbSpecialist.Items.Add("Slaviček");
            cbSpecialist.Items.Add("Kunić");
            cbSpecialist.Items.Add("Primarijus");
        }

        public Model.InstructionsForSpecialistExamination CreateSpecialistExamination()
        {
            Model.InstructionsForSpecialistExamination specialistExamination = new Model.InstructionsForSpecialistExamination(SpecialisticExaminationController.specialisticExaminationService.specialisticExaminationRepository.getNextId(),
                cbSpecialist.Text.ToString() , lblDoctorsName.Content.ToString(), lblPatientsName.Content.ToString(), tbComment.Text.ToString());
            return specialistExamination;
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da izađete?", "Zdravo", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
                this.Close();
            return;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tbComment.Text == "" || cbSpecialist.Text == "")
            {
                MessageBox.Show("Niste popunili sva polja!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                Model.InstructionsForSpecialistExamination specialistExamination = CreateSpecialistExamination();
                SpecialisticExaminationController.CreateSpecialisticExamination(specialistExamination);
                MessageBox.Show("Uspešno ste kreirali izveštaj!", "Uspešno izvršeno!", MessageBoxButton.OK, MessageBoxImage.Information);

                this.Close();
            }
        }
    }
}

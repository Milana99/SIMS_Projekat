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
    /// Interaction logic for SpeialistExamination.xaml
    /// </summary>
    
    public partial class SpeialistExamination : Window
    {
        MedicalRecordDoctor MedicalRecordDoctor;
        public Controller.SpecialisticExaminationController SpecialisticExaminationController;
        public SpeialistExamination(MedicalRecordDoctor medicalRecord)
        {
            InitializeComponent();
            MedicalRecordDoctor = medicalRecord;
            LoadSpecialist();
            lblPatientsName.Content = MedicalRecordDoctor.lbuUsernamePatient.Content;
            SpecialisticExaminationController = new Controller.SpecialisticExaminationController();
        }

        

        public void LoadSpecialist()
        {
            cbSpecialist.Items.Add("Grgeč");
            cbSpecialist.Items.Add("Slaviček");
            cbSpecialist.Items.Add("Kunić");
            cbSpecialist.Items.Add("Primarijus");
        }

        public Model.SpecialistExamination CreateSpecialistExamination()
        {
            Model.SpecialistExamination specialistExamination = new Model.SpecialistExamination(SpecialisticExaminationController.specialisticExaminationService.specialisticExaminationRepository.getNextId(),
                cbSpecialist.Text.ToString() , lblDoctorsName.Content.ToString(), lblPatientsName.Content.ToString(), tbComment.Text.ToString());
            return specialistExamination;
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Model.SpecialistExamination specialistExamination = CreateSpecialistExamination();
            SpecialisticExaminationController.CreateSpecialisticExamination(specialistExamination);
            this.Close();

        }
    }
}

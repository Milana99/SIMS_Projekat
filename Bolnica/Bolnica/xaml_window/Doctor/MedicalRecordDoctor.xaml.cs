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
    /// Interaction logic for MedicalRecordDoctor.xaml
    /// </summary>
    public partial class MedicalRecordDoctor : Window
    {
        AnamnesisOpen ao;
        AnamnesisCreate ac;
        AnamnesisUpdate au;
        AnamnesisTherapy at;

        public Controller.AnamnesisController anamControl;
        public Controller.PrescriptionController pc;
        public DoctorHome dh;
        public MedicalRecordDoctor(DoctorHome d)
        {
            InitializeComponent();
            pc = new Controller.PrescriptionController();
            dh = d;
            anamControl = new Controller.AnamnesisController();
            
            Load();
        }
        public void Load()
        {
            
            Controller.PatientController PatientController = new Controller.PatientController();
            Model.Examination selectedExamination = (Model.Examination)dh.lvDataBinding.SelectedItems[0];
            Model.Patient selectedPatient = PatientController.GetOnePatient(selectedExamination.patient.User.Username);
            lbAddressPatient.Content = selectedPatient.User.Address;
            lbuUsernamePatient.Content = selectedPatient.User.Username;
            lbuJMBG.Content = selectedPatient.User.Jmbg;
            lbNamePatient.Content = selectedPatient.User.Name;
            lbGender.Content = selectedPatient.User.Gender;
            lbDateOfBirthPatient.Content = selectedPatient.User.DateOfBirth;
            lbSurnamePatient.Content = selectedPatient.User.Surname;
            lbNumberPatient.Content = selectedPatient.User.PhoneNumber;

            
            List<Model.Anamnesis> anamneses = anamControl.GetAllAnamnesisPatient(selectedPatient.User.Username);
            lvDataBinding.Items.Clear();
            foreach (Model.Anamnesis an in anamneses)
            {
                lvDataBinding.Items.Add(an);
                Console.WriteLine(an.DescriptionAnamnesis);
            }
        }

        private void Button_Click_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Open_Anamnesis(object sender, RoutedEventArgs e)
        {
            
            Model.Anamnesis selected = (Model.Anamnesis)lvDataBinding.SelectedItems[0];
            ao = new AnamnesisOpen();
            Console.WriteLine(selected.AnamnesisId);
            List<Model.Prescription> prescriptions = pc.GetAllPrescriptionAnamnesis(selected.AnamnesisId);
            foreach(Model.Prescription pr in prescriptions)
            {
                ao.lvDataBindingAnamnesis.Items.Add(pr);
                Console.WriteLine(pr.PrescriptionId);
            }
            ao.lbDescriptionAnamnesis.Content = selected.DescriptionAnamnesis;
            ao.lbOpinionForAnamnesis.Content = selected.OpinionForAnamnesis;
            ao.lbTypeAnamnesis.Content = selected.TypeAnamnesis;
            
            ao.Show();
        }
        public void full_uodate()
        {
            au.lvDataBindingAnamnesis.Items.Clear();
            Model.Anamnesis selected = (Model.Anamnesis)lvDataBinding.SelectedItems[0];
            Console.WriteLine(selected.AnamnesisId);
            List<Model.Prescription> prescriptions = pc.GetAllPrescriptionAnamnesis(selected.AnamnesisId);
            foreach (Model.Prescription pr in prescriptions)
            {
                au.lvDataBindingAnamnesis.Items.Add(pr);
                Console.WriteLine(pr.PrescriptionId);
            }
            au.tbDescriptionAnamnesis.Text = selected.DescriptionAnamnesis;
            au.tbOpinionForAnamnesis.Text = selected.OpinionForAnamnesis;
            au.tbTypeAnamnesis.Text = selected.TypeAnamnesis;
        }
        private void Button_Click_Update_Anamnesis(object sender, RoutedEventArgs e)
        {
            au = new AnamnesisUpdate(this);
            full_uodate();
            au.Show();
        }

        private void Button_Click_Create_Anamnesis(object sender, RoutedEventArgs e)
        {
            ac = new AnamnesisCreate(this);

            ac.Show();
        }


    }
}

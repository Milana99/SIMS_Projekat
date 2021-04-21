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
       public MainWindow mw;
        ExaminationUpdate eu;
        CreateExaminatio ce;
        MedicalRecordDoctor mrd;

        public Model.Doctor doc;
        public Controller.ExaminationController control;
        public List<Model.Examination> examinations;
        public DoctorHome()
        {
            InitializeComponent();
            control = new Controller.ExaminationController();
            LoadAll();
            
        }

        public void LoadAll()
        {
            lvDataBinding.Items.Clear();

            examinations = control.GetAllExaminations();

            foreach (Model.Examination ex in examinations)
            {
                lvDataBinding.Items.Add(ex);
            }
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            Model.Examination selected = (Model.Examination)lvDataBinding.SelectedItems[0];
            control.DeleteExamination(selected.ExaminationId);
            LoadAll();
            MessageBox.Show("Uspešno ste izbrisali termin", "Uspešno!");
        }

        private void Button_Click_Create(object sender, RoutedEventArgs e)
        {
            ce = new CreateExaminatio(this);
            ce.Show();
            
        }

        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {
            eu = new ExaminationUpdate(this);
            eu.Show();
            Model.Examination selected = (Model.Examination)lvDataBinding.SelectedItems[0];
            eu.lbuID.Content = (selected.ExaminationId.ToString());
            eu.lbuPatient.Content = (selected.patient.User.Username);
            eu.tbuStartTime.Text = selected.StartTime.ToString();
            eu.tbuEndTime.Text = selected.EndTime.ToString();
        }

        private void Doctor_Logout(object sender, RoutedEventArgs e)
        {
            mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void Button_Click_Patient(object sender, RoutedEventArgs e)
        {
            Controller.PatientController pc = new Controller.PatientController();
            Model.Examination selected = (Model.Examination)lvDataBinding.SelectedItems[0];
            Model.Patient pat = pc.GetOnePatient(selected.patient.User.Username);

            mrd = new MedicalRecordDoctor();

            mrd.lbAddressPatient.Content = pat.User.Address;
            mrd.lbuUsernamePatient.Content = pat.User.Username;
            mrd.lbuJMBG.Content = pat.User.Jmbg;
            mrd.lbNamePatient.Content = pat.User.Name;
            mrd.lbGender.Content = pat.User.Gender;
            mrd.lbDateOfBirthPatient.Content = pat.User.DateOfBirth;
            mrd.lbSurnamePatient.Content = pat.User.Surname;
            mrd.lbNumberPatient.Content = pat.User.PhoneNumber;
            mrd.Show();

        }

    }
}

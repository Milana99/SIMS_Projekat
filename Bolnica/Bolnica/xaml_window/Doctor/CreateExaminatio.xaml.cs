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
    /// Interaction logic for CreateExaminatio.xaml
    /// </summary>
    public partial class CreateExaminatio : Window
    {
        DoctorHome dh;
        Model.Doctor doctor;
        
        public CreateExaminatio(Model.Doctor doc, DoctorHome doh)
        {
            InitializeComponent();
            doctor = doc;
            cbPatient.Items.Add("Marija11");
            cbPatient.Items.Add("Jelena21");
            cbPatient.Items.Add("Luka99");
            cbPatient.Items.Add("Djordje71");
            cbPatient.SelectedItem = "Djordje71";
            dh = doh;
        }

        private void btnDialogCancel_Click(object sender, RoutedEventArgs e)
        {
          
            this.Close();

        }

        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            Model.Examination ex = new Model.Examination(doctor.exm.next_id,Convert.ToDateTime(tbStartTime.Text),Convert.ToDateTime(tbEndTime.Text), doctor.User.Username, cbPatient.Text, 1);
            doctor.exm.next_id++;
            Boolean b = doctor.AddExaminations(ex);
            if (b == true)
            {
                dh.LoadAll();
                MessageBox.Show("Uspešno ste zakazali termin", "Uspešno!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Izabrani termin se poklapa sa zakazanim", "ERROR");
            }
            
            
        }
    }
}

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
    /// Interaction logic for HospitalTreatment.xaml
    /// </summary>
    public partial class HospitalTreatment : Window
    {
        public HospitalTreatment()
        {
            InitializeComponent();
            
            LoadInstructionsForHospitalTreatment();
        }

        public void LoadInstructionsForHospitalTreatment()
        {
            lvDataBinding.Items.Clear();
            Controller.InstructionsForHospitalTreatmentController instructionsController = new Controller.InstructionsForHospitalTreatmentController();
            Console.WriteLine("vamo");
            List<Model.InstructionsForHospitalTreatment> instructions = instructionsController.GetAllInstructionsForHospitalTreatment();
            Console.WriteLine("ovde");
            foreach (Model.InstructionsForHospitalTreatment instruction in instructions)
            {
                lvDataBinding.Items.Add(instruction);
                Console.WriteLine(instruction.getBed());
            }
        }

        private void ListViewItem_Selected_Calendar(object sender, RoutedEventArgs e)
        {
            var calendar = new DoctorHome();
            calendar.Show();
            this.Close();
        }

        private void ListViewItem_Selected_drugs(object sender, RoutedEventArgs e)
        {
            var drug_list = new DrugList();
            drug_list.Show();
            this.Close();
        }

        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {
            var hospital_treatment_edit = new HospitalTreatmantEdit(this);
            hospital_treatment_edit.Show();
         
        }

        private void Doctor_Logout(object sender, RoutedEventArgs e)
        {
            var main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}

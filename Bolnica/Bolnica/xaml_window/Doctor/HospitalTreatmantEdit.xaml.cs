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
    /// Interaction logic for HospitalTreatmantEdit.xaml
    /// </summary>
    public partial class HospitalTreatmantEdit : Window
    {
        private HospitalTreatment HospitalTreatment;
        public HospitalTreatmantEdit(HospitalTreatment hospitalTreatment)
        {
            InitializeComponent();
            HospitalTreatment = hospitalTreatment;
            LoadComponents();
        }

        public void LoadComponents()
        {
            Model.InstructionsForHospitalTreatment instruction = (Model.InstructionsForHospitalTreatment)HospitalTreatment.lvDataBinding.SelectedItem;
            lbPatient.Content = instruction.getPatient();
            lbRoom.Content = instruction.GetRoom();
            lbStartDate.Content = instruction.getStartDate();
            lbBed.Content = instruction.getBed();
            dpEndDate.Text = instruction.getEndDate().ToString();
        }
        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            changeEndDate();
            HospitalTreatment.LoadInstructionsForHospitalTreatment();
            this.Close();
        }
        private void changeEndDate()
        {
            Model.InstructionsForHospitalTreatment instruction = (Model.InstructionsForHospitalTreatment)HospitalTreatment.lvDataBinding.SelectedItem;
            instruction.UpdateEndDate(DateTime.Parse(dpEndDate.Text));
            Controller.InstructionsForHospitalTreatmentController InstructionsController = new Controller.InstructionsForHospitalTreatmentController();
            InstructionsController.UpdateInstructionsForHospitalTreatment(instruction);
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

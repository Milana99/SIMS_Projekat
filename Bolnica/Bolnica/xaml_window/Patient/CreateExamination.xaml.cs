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

namespace Bolnica.xaml_window.Patient
{
    /// <summary>
    /// Interaction logic for CreateExamination.xaml
    /// </summary>
    public partial class CreateExamination : Window
    {
        public PatientHome ph;
        public Model.Patient pati;
        ExaminationDoctor ed;
        ExaminationTime et;
        public List<Model.Examination> examinations;

        public CreateExamination(Model.Patient pat, PatientHome pah)
        {
            InitializeComponent();
            pati = pat;
            cbDoctor.Items.Add("Dunja23");
            cbDoctor.Items.Add("Milana1");
            cbDoctor.Items.Add("Jelena13");
            cbDoctor.Items.Add("Dusan23");
            cbDoctor.Items.Add("Samira12");
            cbDoctor.Items.Add("Jovana11");
            cbDoctor.SelectedItem = "Samira12";
            ph = pah;

        }

        private void Button_Click_Doctor(object sender, RoutedEventArgs e)
        {
            ed = new ExaminationDoctor(pati, this);
            ed.Show();



        }

        private void Button_Click_Time(object sender, RoutedEventArgs e)
        {
            et = new ExaminationTime(pati, this);
            et.Show();

        }
    }
}

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
    /// Interaction logic for ExaminationTime.xaml
    /// </summary>
    public partial class ExaminationTime : Window
    {
        PatientHome ph;
        Model.Patient patient;
        private Model.Patient pati;
        private CreateExamination createExamination;

        public ExaminationTime(Model.Patient pat, PatientHome pah)
        {
            InitializeComponent();
            patient = pat;
            ph = pah;
        }

        public ExaminationTime(Model.Patient pati, CreateExamination createExamination)
        {
            this.pati = pati;
            this.createExamination = createExamination;
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {

        }
    }
}
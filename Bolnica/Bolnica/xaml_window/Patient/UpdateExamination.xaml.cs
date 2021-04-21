using Bolnica.Model;
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
    /// Interaction logic for UpdateExamination.xaml
    /// </summary>
    public partial class UpdateExamination : Window
    {
        PatientHome ph;
        Model.Patient patient;
        List<Examination> examinations;

        public UpdateExamination(Model.Patient pat, PatientHome pah)
        {
            InitializeComponent();
            patient = pat;
            cbDoctor.Items.Add("Dunja23");
            cbDoctor.Items.Add("Milana1");
            cbDoctor.Items.Add("Jelena13");
            cbDoctor.Items.Add("Dusan23");
            cbDoctor.Items.Add("Samira12");
            cbDoctor.Items.Add("Jovana11");
            ph = pah;
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            int exId = int.Parse(luID.Content.ToString());
            DateTime date = DateTime.Parse(tbuDate.Text);
            DateTime start = DateTime.Parse(tbuStartTime.Text);
            DateTime end = DateTime.Parse(tbuEndTime.Text);
            int month = int.Parse(luMonth.Content.ToString());
            int day = int.Parse(luDay.Content.ToString());
            Boolean p = patient.Update(exId, date, start, end);

            if (p == true)
            {
                ph.LoadAll();
                MessageBox.Show("Uspešno ste izmenili termin!");
                this.Close();
            }

            else
            {
                MessageBox.Show("Izabrani termin se poklapa sa zakazanim!");
            }

        }

       
        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
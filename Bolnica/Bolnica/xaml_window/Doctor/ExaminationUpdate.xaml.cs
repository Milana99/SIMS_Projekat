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
    /// Interaction logic for ExaminationUpdate.xaml
    /// </summary>
    public partial class ExaminationUpdate : Window
    {
        DoctorHome DoctorHome;
        CreateExaminationInventary CreateExaminationInvetory;
        

        public ExaminationUpdate(DoctorHome DoctorHome)
        {
            InitializeComponent();
            this.DoctorHome = DoctorHome;
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void Button_Click_OK(object sender, RoutedEventArgs e)
        {
            int exId = int.Parse(lbuID.Content.ToString());
            DateTime start = DateTime.Parse(DatePick.Text + " " + tbuStartTime.Text);
            DateTime end = DateTime.Parse(DatePick.Text + " " + tbuEndTime.Text);
            
            
            if(DoctorHome.ExaminationControl.UpdateExamination(exId, start, end))
            {
                DoctorHome.LoadAll();
                MessageBox.Show("Uspešno ste izmenili termin", "Uspešno!");
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Izabrani termin se poklapa sa zakazanim", "ERROR");
            }

        }

        private void Button_Click_Inventary(object sender, RoutedEventArgs e)
        {
            CreateExaminationInvetory = new CreateExaminationInventary(int.Parse(cbRoom.Text));
            CreateExaminationInvetory.Show();
        }
    }
}

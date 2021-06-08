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
    /// Interaction logic for DrugConsumptionReport.xaml
    /// </summary>
    public partial class DrugConsumptionReport : Window
    {
        public DrugConsumptionReport()
        {
            InitializeComponent();
        }

        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            var doctor_home = new DoctorHome();
            doctor_home.Show();
            this.Close();
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            var drug_list = new DrugList();
            drug_list.Show();
            this.Close();

        }

        private void ListViewItem_Selected_hospital(object sender, RoutedEventArgs e)
        {
            var hospital_treatment = new HospitalTreatment();
            hospital_treatment.Show();
            this.Close();
        }

        private void Doctor_Logout(object sender, RoutedEventArgs e)
        {
            var main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(dpStart.Text=="" || dpEnd.Text=="")
            {
                MessageBox.Show("Morate uneti datum!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                var drug_report_print = new DrugReportPrint(this);
                drug_report_print.ShowDialog();
            }
            
        }

        private void Button_Click_Add_Drug(object sender, RoutedEventArgs e)
        {
            var add_drug = new DrugReportAddDrug(this);
            add_drug.ShowDialog();
        }
    }
}

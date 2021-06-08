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
    /// Interaction logic for DrugList.xaml
    /// </summary>
    public partial class DrugList : Window
    {
        public DrugList()
        {
            InitializeComponent();
        }

        private void ListViewItem_Selected_Calendar(object sender, RoutedEventArgs e)
        {
            var dh = new DoctorHome();
            dh.Show();
            this.Close();
        }

        private void Button_Click_Drug_Verify(object sender, RoutedEventArgs e)
        {
            var dlv = new DrugListVerify();
            dlv.ShowDialog();
        }

        private void Button_Click_Drug_For_Verify(object sender, RoutedEventArgs e)
        {
            var dlfv = new DrugListForVerify();
            dlfv.ShowDialog();
        }

        private void Doctor_Logout(object sender, RoutedEventArgs e)
        {
            var mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void ListViewItem_Selected_Instructions_For_Hospital_Treatment(object sender, RoutedEventArgs e)
        {
            var instructions_for_hospital_treatment = new HospitalTreatment();
            instructions_for_hospital_treatment.Show();
            this.Close();
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            var drug_report = new DrugConsumptionReport();
            drug_report.Show();
            this.Close();
        }
    }
}

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
    /// Interaction logic for DrugReportPrint.xaml
    /// </summary>
    public partial class DrugReportPrint : Window
    {
        DrugConsumptionReport drugConsumption;
        public DrugReportPrint(DrugConsumptionReport drugConsumptionReport)
        {
            InitializeComponent();
            drugConsumption = drugConsumptionReport;
            LoadDrugs();
            SetDate();
        }
        
        public void LoadDrugs()
        {
            for (int i =0; i<drugConsumption.lvDataBinding.Items.Count; i++)
            {
                lvDataBinding.Items.Add(drugConsumption.lvDataBinding.Items[i]);
            }
        }
        public void SetDate()
        {
            lbDate.Content = drugConsumption.dpStart.SelectedDate;
            lbDateEnd.Content = drugConsumption.dpEnd.SelectedDate;
            lbPrintDate.Content = DateTime.Now.Date;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Uspešno ste odštampali zveštaj!", "Uspešno izvršeno!", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da izađete?", "Zdravo", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
                this.Close();
            return;
        }
    }
}

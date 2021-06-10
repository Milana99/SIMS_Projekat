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
using System.ComponentModel;

namespace Bolnica.xaml_window.Doctor
{
    /// <summary>
    /// Interaction logic for DrugReportAddDrug.xaml
    /// </summary>
    
    public partial class DrugReportAddDrug : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string quantity;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        public string Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value != quantity)
                {
                    quantity = value;
                    OnPropertyChanged("Quantity");
                }

            }
        }
        public DrugConsumptionReport drugConsumption;
        public DrugReportAddDrug(DrugConsumptionReport drugConsumptionReport)
        {
            InitializeComponent();
            this.DataContext = this;
            drugConsumption = drugConsumptionReport;
            LoadDrugs();
            
        }
        public void LoadDrugs()
        {
            Controller.DrugController drugController = new Controller.DrugController();
            List<Model.Drug> drugs = drugController.GetAllDrugs();
            foreach(Model.Drug drug in drugs)
            {
                if(drug.DrugType == Model.TypeOfApprovedDrug.Approved)
                {
                    cbDrugName.Items.Add(drug.DrugName);
                }
            }
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            if (tbQuantityOfDrug.Text == "" || tbQuantityOfDrug.Text == null)
            {
                MessageBox.Show("Niste popunili sva polja!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
                tbQuantityOfDrug.BorderBrush = Brushes.Red;
            }
            else
            {
                Controller.DrugController drugController = new Controller.DrugController();
                Model.Drug drug = drugController.GetDrugByName(cbDrugName.Text);
                drug.DrugQuantity = int.Parse(tbQuantityOfDrug.Text);
                drugConsumption.lvDataBinding.Items.Add(drug);
                MessageBox.Show("Uspešno ste dodali lek!", "Uspešno izvršeno!", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da izađete?", "Zdravo", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
                this.Close();
            return; ;
        }
    }
}

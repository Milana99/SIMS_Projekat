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

namespace Bolnica.xaml_window.Manager
{
    /// <summary>
    /// Interaction logic for DrugCreate.xaml
    /// </summary>

    public partial class DrugCreate : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        DrugList drugList;
        private string drugName;
        private string drugDescription;
        private int drugQuantity;
        private double drugWeight;
        private string drugComponents;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        public string DrugName
        {
            get
            {
                return drugName;
            }
            set
            {
                if (value != drugName)
                {
                    drugName = value;
                    OnPropertyChanged("DrugName");
                }

            }
        }
        public string DrugDescription
        {

            get
            {
                return drugDescription;
            }
            set
            {
                if (value != drugDescription)
                {
                    drugDescription = value;
                    OnPropertyChanged("DrugDescription");
                }

            }
        }
        public int DrugQuantity
        {

            get
            {
                return drugQuantity;
            }
            set
            {
                if (value != drugQuantity)
                {
                    drugQuantity = value;
                    OnPropertyChanged("DrugQuantity");
                }

            }
        }
        public double DrugWeight
        {

            get
            {
                return drugWeight;
            }
            set
            {
                if (value != drugWeight)
                {
                    drugWeight = value;
                    OnPropertyChanged("DrugWeight");
                }

            }
        }
        public string DrugComponents
        {

            get
            {
                return drugComponents;
            }
            set
            {
                if (value != drugComponents)
                {
                    drugComponents = value;
                    OnPropertyChanged("DrugComponents");
                }

            }
        }
        public DrugCreate(DrugList dl)
        {
            InitializeComponent();
            this.DataContext = this;
            drugList = dl;
            lblDrugId.Content = drugList.drugController.drugService.drugRepository.getNextId();
            LoadAlternatives();
        }

        private void LoadAlternatives()
        {
            List<Model.Drug> drugs = drugList.drugController.GetAllDrugs();
            foreach(Model.Drug drug in drugs)
            {
                if(drug.DrugType == Model.TypeOfApprovedDrug.Approved)
                {
                    cbAlternativeDrug.Items.Add(drug.DrugName);
                }
            }
            cbAlternativeDrug.Items.Add("Nema");
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da izađete?", "Zdravo", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
            {
                drugList.Show();
                this.Close();
            }
            return;
        }

        private Model.Drug CreateDrug()
        {
            Model.Drug drug = new Model.Drug(int.Parse(lblDrugId.Content.ToString()), tbDrugName.Text,
                tbDrugDescription.Text, int.Parse(tbDrugQuantity.Text), double.Parse(tbDrugWeight.Text), tbDrugComponents.Text,
                Model.TypeOfApprovedDrug.Waiting, cbAlternativeDrug.Text, "");
            return drug;
        }
        private void Button_Click_OK(object sender, RoutedEventArgs e)
        {
            if (tbDrugComponents.Text == "" || tbDrugComponents.Text == null || tbDrugDescription.Text == "" || tbDrugDescription.Text == null
               || tbDrugName.Text == "" || tbDrugName.Text == null || tbDrugQuantity.Text == "" || tbDrugQuantity.Text== null
               || tbDrugWeight.Text == "" || tbDrugWeight.Text == null )
            {
                MessageBox.Show("Niste popunili sva polja!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                Model.Drug drug = CreateDrug();
                drugList.drugController.CreateDrug(drug);
                drugList.Show();
                drugList.LoadAll();
                this.Close();
                MessageBox.Show("Uspešno ste kreirali lek!", "Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }
    }
}

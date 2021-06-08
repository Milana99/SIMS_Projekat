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
    /// Interaction logic for DrugListVerifyEdit.xaml
    /// </summary>
    public partial class DrugListVerifyEdit : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        DrugListVerify drugListVerify;
        private string drugDescription;
        private int drugQuantity;
        private double drugWeight;
        private string drugComponents;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        public string DrugDesc
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
                    OnPropertyChanged("DrugDesc");
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
        public DrugListVerifyEdit(DrugListVerify drugListVerify)
        {
            InitializeComponent();
            this.DataContext = this;
            this.drugListVerify = drugListVerify;
            LoadAllComponents();
        }

        public void LoadAlternatives()
        {
            List<Model.Drug> drugs = drugListVerify.drugController.GetAllDrugs();
            foreach(Model.Drug drug in drugs)
            {
                if(drug.DrugType == Model.TypeOfApprovedDrug.Approved)
                {
                    cbAlternativeDrug.Items.Add(drug.DrugName);
                }
            }
            cbAlternativeDrug.Items.Add("Nema");
        }
        public void LoadAllComponents()
        {
            Model.Drug selected = (Model.Drug)drugListVerify.lvDataBindingDrugs.SelectedItems[0];
            lbDrugId.Content = selected.DrugId;
            lbDrugName.Content = selected.DrugName;
            drugComponents = selected.DrugComponents;
            drugDescription = selected.DrugDescription;
            drugQuantity = selected.DrugQuantity;
            drugWeight = selected.DrugWeight;
            LoadAlternatives();
            cbAlternativeDrug.SelectedItem = selected.AlternativeDrug.ToString();
            
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da izađete?", "Zdravo", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
                this.Close();
            return;
        }
        private Model.Drug CreateDrug()
        {
            Model.Drug drug = new Model.Drug(int.Parse(lbDrugId.Content.ToString()), lbDrugName.Content.ToString(),
                tbuDrugDescription.Text, int.Parse(tbuDrugQuantity.Text), double.Parse(tbuDrugWeight.Text),
                tbuDrugComponents.Text, Model.TypeOfApprovedDrug.Approved, cbAlternativeDrug.Text,"");
            return drug;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(tbuDrugComponents.Text=="" || tbuDrugDescription.Text=="" || tbuDrugQuantity.Text=="" || tbuDrugWeight.Text=="")
            {
                MessageBox.Show("Niste popunili sva polja!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            else
            {
                Model.Drug drug = CreateDrug();
                drugListVerify.drugController.UpdateDrug(drug);
                drugListVerify.LoadAll();
                MessageBox.Show("Uspešno ste kreirali izveštaj!", "Uspešno izvršeno!", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
        }
    }
}

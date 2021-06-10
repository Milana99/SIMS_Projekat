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
    /// Interaction logic for AnamnesisTherapyAdd.xaml
    /// </summary>
    public partial class AnamnesisTherapyAdd : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public MedicalRecordDoctor mrd;
        public AnamnesisCreate ac;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        private int test1;
        private string test2;
        public int Test1
        {
            get
            {
                return test1;
            }
            set
            {
                if (value != test1)
                {
                    test1 = value;
                    OnPropertyChanged("Test1");
                }

            }
        }
        public string Test2
        {
            get
            {
                return test2;
            }
            set
            {
                if (value != test2)
                {
                    test2 = value;
                    OnPropertyChanged("Test2");
                }

            }
        }
        public AnamnesisTherapyAdd(MedicalRecordDoctor m)
        {
            InitializeComponent();
            mrd = m;
            LoadDrugs();
            lbDrugName.Content = mrd.pc.prescriptionService.prescriptionRepository.next_id.ToString();
            ac = null;
            this.DataContext = this;
        }
        public void LoadDrugs()
        {
            Controller.DrugController drugController = new Controller.DrugController();
            List<Model.Drug> drugs = drugController.GetAllDrugs();
            foreach(Model.Drug drug in drugs)
            {
                if(drug.DrugType == Model.TypeOfApprovedDrug.Approved)
                {
                    cbDrugAdd.Items.Add(drug.DrugName);
                }
            }
        }
        public AnamnesisTherapyAdd(MedicalRecordDoctor m, AnamnesisCreate a)
        {
            InitializeComponent();
            mrd = m;
            LoadDrugs();
            lbDrugName.Content = mrd.pc.prescriptionService.prescriptionRepository.next_id.ToString();
            ac = a;
            this.DataContext = this;
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da izađete?", "Zdravo", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
                this.Close();
            return;
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            if (cbDrugAdd.Text == "" || tbDescriptionPrescription.Text == "" || tbDrugQuantity.Text == "" || tbEndDate.Text == ""
                || tbStartDate.Text == "Select a date")
            {
                check_validation();
            }
            else
            {
                if (ac == null)
                {
                    mrd.pc.CreatePrescription(((Model.Anamnesis)mrd.lvDataBinding.SelectedItems[0]).AnamnesisId,
                    int.Parse(lbDrugName.Content.ToString()), Convert.ToDateTime(tbStartDate.Text), Convert.ToDateTime(tbEndDate.Text),
                    tbDescriptionPrescription.Text, int.Parse(tbDrugQuantity.Text), cbDrugAdd.Text);
                    mrd.full_uodate();
                }
                else
                {
                    Model.Prescription prescription = new Model.Prescription(int.Parse(lbDrugName.Content.ToString()),
                        mrd.pc.prescriptionService.prescriptionRepository.next_id, Convert.ToDateTime(tbStartDate.Text),
                        Convert.ToDateTime(tbEndDate.Text), tbDescriptionPrescription.Text, int.Parse(tbDrugQuantity.Text), cbDrugAdd.Text);

                    ac.lvDataBindingAnamnesis.Items.Add(prescription);
                }
                MessageBox.Show("Uspešno ste dodali recept!", "Uspešno izvršeno!", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
        }

        private void check_validation()
        {
            MessageBox.Show("Niste popunili sva polja!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
            
            
            if (tbDrugQuantity.Text == "")
            {
                tbDrugQuantity.BorderBrush = Brushes.Red;
            }
            if (tbDescriptionPrescription.Text == "")
            {
                tbDescriptionPrescription.BorderBrush = Brushes.Red;
            }
            if (tbDrugQuantity.Text == "")
            {
                tbDrugQuantity.BorderBrush = Brushes.Black;
            }
            if (tbDescriptionPrescription.Text == "")
            {
                tbDescriptionPrescription.BorderBrush = Brushes.Black;
            }
        }

        private void cbDrugAdd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Controller.AllergenController allergenController = new Controller.AllergenController();
            List<Model.Allergen> PatientAllergens = allergenController.GetAllergensForPatient(mrd.lbuUsernamePatient.Content.ToString());
            foreach(Model.Allergen allergen in PatientAllergens)
            {
                if(allergen.getDrug() == cbDrugAdd.SelectedItem.ToString())
                {
                    MessageBox.Show("Korisnik je alergican na izabrani lek");
                }
            }
        }
    }
}

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
    /// Interaction logic for AnamnesisTherapyAdd.xaml
    /// </summary>
    public partial class AnamnesisTherapyAdd : Window
    {
        public MedicalRecordDoctor mrd;
        public AnamnesisCreate ac;
        public AnamnesisTherapyAdd(MedicalRecordDoctor m)
        {
            InitializeComponent();
            mrd = m;
            LoadDrugs();
            lbDrugName.Content = mrd.pc.prescriptionService.prescriptionRepository.next_id.ToString();
            ac = null;
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
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            if(ac==null)
            {
                mrd.pc.CreatePrescription(((Model.Anamnesis)mrd.lvDataBinding.SelectedItems[0]).AnamnesisId,
                int.Parse(lbDrugName.Content.ToString()), Convert.ToDateTime(tbStartDate.Text), Convert.ToDateTime(tbEndDate.Text),
                tbDescriptionPrescription.Text, int.Parse(tbDrugQuantity.Text), cbDrugAdd.Text);
                mrd.full_uodate();
            }
            else
            {
                Model.Prescription prescription= new Model.Prescription(int.Parse(lbDrugName.Content.ToString()),
                    mrd.pc.prescriptionService.prescriptionRepository.next_id, Convert.ToDateTime(tbStartDate.Text),
                    Convert.ToDateTime(tbEndDate.Text), tbDescriptionPrescription.Text, int.Parse(tbDrugQuantity.Text), cbDrugAdd.Text);
                
                ac.lvDataBindingAnamnesis.Items.Add(prescription);
            }
            
            this.Close();
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

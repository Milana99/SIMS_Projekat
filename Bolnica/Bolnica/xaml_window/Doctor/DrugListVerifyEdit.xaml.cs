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
    /// Interaction logic for DrugListVerifyEdit.xaml
    /// </summary>
    public partial class DrugListVerifyEdit : Window
    {
        DrugListVerify drugListVerify;
        public DrugListVerifyEdit(DrugListVerify drugListVerify)
        {
            InitializeComponent();
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
            tbuDrugComponents.Text = selected.DrugComponents;
            tbuDrugDescription.Text = selected.DrugDescription;
            tbuDrugQuantity.Text = selected.DrugQuantity.ToString();
            tbuDrugWeight.Text = selected.DrugWeight.ToString();
            LoadAlternatives();
            cbAlternativeDrug.SelectedItem = selected.AlternativeDrug.ToString();
            
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
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
            Model.Drug drug = CreateDrug();
            drugListVerify.drugController.UpdateDrug(drug);
            drugListVerify.LoadAll();
            this.Close();
        }
    }
}

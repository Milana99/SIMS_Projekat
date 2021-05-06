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

namespace Bolnica.xaml_window.Manager
{
    /// <summary>
    /// Interaction logic for DrugUpdate.xaml
    /// </summary>
    public partial class DrugUpdate : Window
    {
        DrugList drugList;
        public DrugUpdate(DrugList drugList)
        {
            InitializeComponent();
            this.drugList = drugList;
            LoadAllComponents();
            
        }
        private void LoadAlternatives()
        {
            List<Model.Drug> drugs = drugList.drugController.GetAllDrugs();
            foreach (Model.Drug drug in drugs)
            {
                if (drug.DrugType == Model.TypeOfApprovedDrug.Approved)
                {
                    cbAlternativeDrug.Items.Add(drug.DrugName);
                }
            }
            cbAlternativeDrug.Items.Add("Nema");
        }
        public void LoadAllComponents()
        {
            Model.Drug selected = (Model.Drug)drugList.lvDataBinding.SelectedItems[0];
            lblDrugId.Content = selected.DrugId;
            tbDrugName.Text = selected.DrugName;
            tbDrugDescription.Text = selected.DrugDescription;
            tbDrugQuantity.Text = selected.DrugQuantity.ToString();
            tbDrugWeight.Text = selected.DrugWeight.ToString();
            tbDrugComponents.Text = selected.DrugComponents;
            LoadAlternatives();
            cbAlternativeDrug.SelectedItem = selected.AlternativeDrug;

        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            
            drugList.Show();
            this.Close();
        }

        private Model.Drug getDrug()
        {
            Model.Drug drug = new Model.Drug(int.Parse(lblDrugId.Content.ToString()), tbDrugName.Text,
                tbDrugDescription.Text, int.Parse(tbDrugQuantity.Text), double.Parse(tbDrugWeight.Text),
                tbDrugComponents.Text, Model.TypeOfApprovedDrug.Waiting, cbAlternativeDrug.SelectedItem.ToString());
            return drug;
        }

        private void Button_Click_OK(object sender, RoutedEventArgs e)
        {
            Model.Drug drug = getDrug();
            drugList.drugController.UpdateDrug(drug);
            drugList.LoadAll();
            drugList.Show();
            this.Close();
        }
    }
}

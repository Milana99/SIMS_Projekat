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
    /// Interaction logic for DrugCreate.xaml
    /// </summary>

    public partial class DrugCreate : Window
    {
        DrugList drugList;
        public DrugCreate(DrugList dl)
        {
            InitializeComponent();
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

            drugList.Show();
            this.Close();
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
            Model.Drug drug = CreateDrug();
            drugList.drugController.CreateDrug(drug);
            drugList.Show();
            drugList.LoadAll();
            this.Close();
        }
    }
}

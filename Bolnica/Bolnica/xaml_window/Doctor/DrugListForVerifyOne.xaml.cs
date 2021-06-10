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
    /// Interaction logic for DrugListForVerifyOne.xaml
    /// </summary>
    public partial class DrugListForVerifyOne : Window
    {
        public DrugListForVerify drugListForVerify;
        public DrugListForVerifyOne(DrugListForVerify drugListForVerify)
        {
            InitializeComponent();
            this.drugListForVerify = drugListForVerify;
            LoadComponents();
        }
        public void LoadComponents()
        {
            Model.Drug selectedDrug = (Model.Drug)drugListForVerify.lvDataBindingDrugs.SelectedItems[0];
            lblDrugId.Content = selectedDrug.DrugId;
            lblDrugName.Content = selectedDrug.DrugName;
            lblDrugDescription.Content = selectedDrug.DrugDescription;
            lblDrugComponents.Content = selectedDrug.DrugComponents;
            lblDrugQuantity.Content = selectedDrug.DrugQuantity;
            lblDrugWeight.Content = selectedDrug.DrugWeight;
            lblDrugAlternative.Content = selectedDrug.AlternativeDrug;
        }
        private void Button_Click_OK(object sender, RoutedEventArgs e)
        {
            Model.Drug selectedDrug = (Model.Drug)drugListForVerify.lvDataBindingDrugs.SelectedItems[0];
            selectedDrug.DrugType = Model.TypeOfApprovedDrug.Approved;
            drugListForVerify.drugController.UpdateDrug(selectedDrug);
            drugListForVerify.LoadAllDrugs();
            MessageBox.Show("Uspešno ste potvrdili lek!", "Uspešno izvršeno!", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            var dlfvc = new DrugListForVerifyCancel(this);
            dlfvc.ShowDialog();
        }
    }
}

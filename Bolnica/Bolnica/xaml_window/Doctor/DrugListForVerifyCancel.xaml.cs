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
    /// Interaction logic for DrugListForVerifyCancel.xaml
    /// </summary>
    public partial class DrugListForVerifyCancel : Window
    {
        DrugListForVerifyOne DrugListForVerifyOne;
        public DrugListForVerifyCancel(DrugListForVerifyOne drugListForVerifyOne)
        {
            InitializeComponent();
            this.DrugListForVerifyOne = drugListForVerifyOne;
        }

        private void Button_Click_OK(object sender, RoutedEventArgs e)
        {
            Model.Drug selected = (Model.Drug)DrugListForVerifyOne.drugListForVerify.lvDataBindingDrugs.SelectedItems[0];
            selected.DrugType = Model.TypeOfApprovedDrug.NotApproved;
            selected.DrugComment = tbComment.Text.ToString();
            DrugListForVerifyOne.drugListForVerify.drugController.UpdateDrug(selected);
            DrugListForVerifyOne.drugListForVerify.LoadAllDrugs();
            DrugListForVerifyOne.Close();
            this.Close();
        }

        private void Button_Click_Canel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

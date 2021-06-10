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
    /// Interaction logic for DrugListVerify.xaml
    /// </summary>
    public partial class DrugListVerify : Window
    {
        public Controller.DrugController drugController;
        public DrugListVerify()
        {
            InitializeComponent();
            drugController = new Controller.DrugController();
            LoadAll();
        }

        

        public void LoadAll()
        {
            lvDataBindingDrugs.Items.Clear();
            List<Model.Drug> drugs = drugController.GetAllDrugs();
            foreach(Model.Drug drug in drugs)
            {
                if(drug.DrugType == Model.TypeOfApprovedDrug.Approved)
                {
                    lvDataBindingDrugs.Items.Add(drug);
                }
            }
        }

        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {
            var dlvu = new DrugListVerifyEdit(this);
            dlvu.ShowDialog();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

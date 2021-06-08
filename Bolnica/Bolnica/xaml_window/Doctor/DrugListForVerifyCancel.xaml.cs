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
    /// Interaction logic for DrugListForVerifyCancel.xaml
    /// </summary>
    public partial class DrugListForVerifyCancel : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        DrugListForVerifyOne DrugListForVerifyOne;
        private string message;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                if (value != message)
                {
                    message = value;
                    OnPropertyChanged("Message");
                }

            }
        }
        public DrugListForVerifyCancel(DrugListForVerifyOne drugListForVerifyOne)
        {
            InitializeComponent();
            this.DrugListForVerifyOne = drugListForVerifyOne;
        }

        private void Button_Click_OK(object sender, RoutedEventArgs e)
        {
            if (tbComment.Text == "" || tbComment.Text == null)
            {
                check_validation();
            }
            else
            {
                Model.Drug selected = (Model.Drug)DrugListForVerifyOne.drugListForVerify.lvDataBindingDrugs.SelectedItems[0];
                selected.DrugType = Model.TypeOfApprovedDrug.NotApproved;
                selected.DrugComment = tbComment.Text.ToString();
                DrugListForVerifyOne.drugListForVerify.drugController.UpdateDrug(selected);
                DrugListForVerifyOne.drugListForVerify.LoadAllDrugs();
                DrugListForVerifyOne.Close();
                MessageBox.Show("Uspešno ste poslali obrazloženje!", "Uspešno izvršeno!", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
        }
        private void check_validation()
        {

            MessageBox.Show("Niste popunili sva polja!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
            if (tbComment.Text == "" || tbComment.Text == null)
            {
                tbComment.BorderBrush = Brushes.Red;
            }
        }

            private void Button_Click_Canel(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da izađete?", "Zdravo", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
                this.Close();
            return;
        }
    }
}

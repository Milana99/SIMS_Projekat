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

namespace Bolnica.xaml_window.Manager
{
    /// <summary>
    /// Interaction logic for DynamicEquipmentCreate.xaml
    /// </summary>
    public partial class DynamicEquipmentCreate : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public DynamicEquipment de;
        private string nameDynamicEq;
        private int quantityDynamicEq;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        public string NameDynamicEq
        {
            get
            {
                return nameDynamicEq;
            }
            set
            {
                if (value != nameDynamicEq)
                {
                    nameDynamicEq = value;
                    OnPropertyChanged("NameDynamicEq");
                }

            }
        }
        public int QuantityDynamicEq
        {

            get
            {
                return quantityDynamicEq;
            }
            set
            {
                if (value != quantityDynamicEq)
                {
                    quantityDynamicEq = value;
                    OnPropertyChanged("QuantityDynamicEq");
                }

            }
        }
        public DynamicEquipmentCreate(DynamicEquipment d)
        {

            InitializeComponent();
            this.DataContext = this;
            de = d;
            lbIDDynamicEq.Content = de.control.dynamicEquipmentService.dynamicEquipmentRepository.getNextId();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da izađete?", "Zdravo", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
            return;
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            if (tbNameDynamicEq.Text == "" || tbNameDynamicEq.Text == null || tbQuantityDynamicEq.Text == "" || tbQuantityDynamicEq.Text == null
              )
            {
                MessageBox.Show("Niste popunili sva polja!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                de.control.CreateDynamicEquipment(int.Parse(lbIDDynamicEq.Content.ToString()), int.Parse(tbQuantityDynamicEq.Text), tbNameDynamicEq.Text);
                de.Load();
                this.Close();
                MessageBox.Show("Uspešno ste kreirali dinamičku opremu!", "Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}

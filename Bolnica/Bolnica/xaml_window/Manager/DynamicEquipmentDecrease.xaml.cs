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
    /// Interaction logic for DynamicEquipmentDecrease.xaml
    /// </summary>
    public partial class DynamicEquipmentDecrease : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public DynamicEquipment de;
        public int Quantity;
        private int quantityDynamicEq;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
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
        public DynamicEquipmentDecrease(DynamicEquipment d, int oldQuantity)
        {
            InitializeComponent();
            this.DataContext = this;
            Quantity = oldQuantity;
            de = d;
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
            if (tbdQuantityDynamicEq.Text == "" || tbdQuantityDynamicEq.Text == null)
            {
                MessageBox.Show("Niste popunili sva polja!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if (int.Parse(tbdQuantityDynamicEq.Text) > Quantity)
                {
                    MessageBox.Show("Uneta količina je veća od raspoložive", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);

                }
                else
                {
                    Quantity -= int.Parse(tbdQuantityDynamicEq.Text);
                    de.control.UpdateDynamicEquipment(int.Parse(lbdIDDynamicEq.Content.ToString()), Quantity, lbdNameDynamicEq.Content.ToString());

                    de.Load();
                    this.Close();
                    MessageBox.Show("Uspešno ste oduzeli količinu dinamičke opreme!", "Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }
        }
    }
}

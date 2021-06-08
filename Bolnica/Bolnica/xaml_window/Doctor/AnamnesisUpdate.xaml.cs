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
    /// Interaction logic for AnamnesisUpdate.xaml
    /// </summary>
    public partial class AnamnesisUpdate : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        AnamnesisTherapyAdd at;
        MedicalRecordDoctor mrd;
        public string typeOfAnamnesis;
        public string descriptionAnamnesis;
        public string opinionForAnamnesis;
        
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        public string TypeOfAnamnesis
        {
            
            get
            {
                
                return typeOfAnamnesis;
            }
            set
            {
                if (value != typeOfAnamnesis)
                {
                    typeOfAnamnesis = value;
                    OnPropertyChanged("TypeOfAnamnesis");
                }

            }
        }
        public string DescriptionAnamnesis
        {

            get
            {
                
                return descriptionAnamnesis;
            }
            set
            {
                if (value != descriptionAnamnesis)
                {
                    descriptionAnamnesis = value;
                    OnPropertyChanged("DescriptionAnamnesis");
                }

            }
        }
        public string OpinionForAnamnesis
        {

            get
            {
                
                return opinionForAnamnesis;
            }
            set
            {
                if (value != opinionForAnamnesis)
                {
                    opinionForAnamnesis = value;
                    OnPropertyChanged("OpinionForAnamnesis");
                }

            }
        }
        public AnamnesisUpdate(MedicalRecordDoctor m)
        {
            InitializeComponent();
            mrd = m;
            this.DataContext = this;
        }

        private void Button_Click_Therapy(object sender, RoutedEventArgs e)
        {
            at = new AnamnesisTherapyAdd(mrd);
            at.ShowDialog();
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            if (tbDescriptionAnamnesis.Text == "" || tbDescriptionAnamnesis.Text == null || tbOpinionForAnamnesis.Text == "" || tbOpinionForAnamnesis.Text == null
                || tbTypeAnamnesis.Text == "" || tbTypeAnamnesis.Text == null)
            {
                check_validation();
            }
            else
            {
                Model.Anamnesis selected = (Model.Anamnesis)mrd.lvDataBinding.SelectedItems[0];
                mrd.anamControl.UpdateAnamnesis(selected.AnamnesisId, tbTypeAnamnesis.Text, tbDescriptionAnamnesis.Text, tbOpinionForAnamnesis.Text);
                MessageBox.Show("Uspešno ste izmenili izveštaj!", "Uspešno izvršeno!", MessageBoxButton.OK, MessageBoxImage.Information);
                mrd.Load();
                this.Close();
            }
        }
        private void check_validation()
        {

            MessageBox.Show("Niste popunili sva polja!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
            if (tbTypeAnamnesis.Text == "" || tbTypeAnamnesis.Text == null)
            {
                tbTypeAnamnesis.BorderBrush = Brushes.Red;
            }
            if (tbDescriptionAnamnesis.Text == "" || tbDescriptionAnamnesis.Text == null)
            {
                tbDescriptionAnamnesis.BorderBrush = Brushes.Red;
            }
            if (tbOpinionForAnamnesis.Text == "" || tbOpinionForAnamnesis.Text == null)
            {

                tbOpinionForAnamnesis.BorderBrush = Brushes.Red;
            }
            if (tbTypeAnamnesis.Text != "")
            {
                tbTypeAnamnesis.BorderBrush = Brushes.Black;
            }
            if (tbDescriptionAnamnesis.Text != "")
            {
                tbDescriptionAnamnesis.BorderBrush = Brushes.Black;
            }
            if (tbOpinionForAnamnesis.Text != "")
            {
                tbOpinionForAnamnesis.BorderBrush = Brushes.Black;
            }
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da izađete?", "Zdravo", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
                this.Close();
            return;
        }
    }
}

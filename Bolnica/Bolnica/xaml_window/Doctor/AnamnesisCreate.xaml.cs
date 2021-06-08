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
using System.Threading.Tasks;

namespace Bolnica.xaml_window.Doctor
{
    /// <summary>
    /// Interaction logic for AnamnesisCreate.xaml
    /// </summary>
    public partial class AnamnesisCreate : Window, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        AnamnesisTherapyAdd ata;
        public MedicalRecordDoctor mrd;
        private string typeOfAnamnesis;
        private string descriptionAnamnesis;
        private string opinionForAnamnesis;
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
        public AnamnesisCreate(MedicalRecordDoctor m)
        {
            InitializeComponent();
            this.DataContext = this;
            mrd = m;
            
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da izađete?", "Zdravo", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
                this.Close();
            return;
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
                int id = mrd.anamControl.anamnesisService.anamnesisRepository.next_id;
                mrd.anamControl.anamnesisService.anamnesisRepository.next_id++;
                mrd.anamControl.CreateAnamnesis(mrd.lbuUsernamePatient.Content.ToString(), id,
                    tbTypeAnamnesis.Text, tbDescriptionAnamnesis.Text, tbOpinionForAnamnesis.Text);

                for (int i = 0; i < lvDataBindingAnamnesis.Items.Count; i++)
                {
                    Model.Prescription prescription = (Model.Prescription)(lvDataBindingAnamnesis.Items[i]);
                    mrd.pc.CreatePrescription(id, mrd.pc.prescriptionService.prescriptionRepository.next_id,
                        prescription.StartDatePrescription, prescription.EndDatePrescription, prescription.DescriptionPrescription,
                        prescription.QuantityPrescription, prescription.drug.DrugName);
                }
                MessageBox.Show("Uspešno ste kreirali uput za doktora specijalistu!", "Uspešno izvršeno!", MessageBoxButton.OK, MessageBoxImage.Information);
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
            if(tbDescriptionAnamnesis.Text == "" || tbDescriptionAnamnesis.Text == null)
            {
                tbDescriptionAnamnesis.BorderBrush = Brushes.Red;
            }
            if(tbOpinionForAnamnesis.Text == "" || tbOpinionForAnamnesis.Text == null)
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

        private void Button_Click_Therapy(object sender, RoutedEventArgs e)
        {
            ata = new AnamnesisTherapyAdd(mrd, this);
            ata.ShowDialog();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Brush color = btnDemo.Background;

            tbTypeAnamnesis.Text = "";
            await Task.Delay(1000);
            tbTypeAnamnesis.Text = "T";
            await Task.Delay(10);
            tbTypeAnamnesis.Text = "Ti";
            await Task.Delay(10);
            tbTypeAnamnesis.Text = "Tip";
            await Task.Delay(10);
            tbTypeAnamnesis.Text = "Tip ";
            await Task.Delay(10);
            tbTypeAnamnesis.Text = "Tip a";
            await Task.Delay(10);
            tbTypeAnamnesis.Text = "Tip an";
            await Task.Delay(10);
            tbTypeAnamnesis.Text = "Tip ana";
            await Task.Delay(10);
            tbTypeAnamnesis.Text = "Tip anam";
            await Task.Delay(10);
            tbTypeAnamnesis.Text = "Tip anamn";
            await Task.Delay(10);
            tbTypeAnamnesis.Text = "Tip anamne";
            await Task.Delay(10);
            tbTypeAnamnesis.Text = "Tip anamnez";
            await Task.Delay(10);
            tbTypeAnamnesis.Text = "Tip anamneze";

            await Task.Delay(1000);
            tbDescriptionAnamnesis.Text = "";
            await Task.Delay(1000);
            tbDescriptionAnamnesis.Text = "O";
            await Task.Delay(10);
            tbDescriptionAnamnesis.Text = "Op";
            await Task.Delay(10);
            tbDescriptionAnamnesis.Text = "Opi";
            await Task.Delay(10);
            tbDescriptionAnamnesis.Text = "Opis";

            tbOpinionForAnamnesis.Text = "";
            await Task.Delay(1000);
            tbOpinionForAnamnesis.Text = "M";
            await Task.Delay(10);
            tbOpinionForAnamnesis.Text = "Mi";
            await Task.Delay(10);
            tbOpinionForAnamnesis.Text = "Miš";
            await Task.Delay(10);
            tbOpinionForAnamnesis.Text = "Mišl";
            await Task.Delay(10);
            tbOpinionForAnamnesis.Text = "Mišlj";
            await Task.Delay(10);
            tbOpinionForAnamnesis.Text = "Mišlje";
            await Task.Delay(10);
            tbOpinionForAnamnesis.Text = "Mišljen";
            await Task.Delay(10);
            tbOpinionForAnamnesis.Text = "Mišljenj";
            await Task.Delay(10);
            tbOpinionForAnamnesis.Text = "Mišljenje";

            await Task.Delay(1000);
            btnPlus.Background = Brushes.DarkGreen;
            
            await Task.Delay(1000);
            AnamnesisTherapyAdd at = new AnamnesisTherapyAdd(mrd);
            at.Show();
            int i = 9;
            await Task.Delay(1000);
            DateTime dt = new DateTime(12/12/2021);
            
            at.tbDescriptionPrescription.Text = "Ovde unosite opis recepta";
            await Task.Delay(1000);
            at.tbDrugQuantity.Text = i.ToString();
            await Task.Delay(1000);
            at.tbEndDate.Text = dt.ToString();
            await Task.Delay(1000);
            at.tbStartDate.Text = dt.ToString();


            await Task.Delay(1000);
            at.Close();

            await Task.Delay(2000);

            tbTypeAnamnesis.Text = "";
            await Task.Delay(1000);
            tbDescriptionAnamnesis.Text = "";
            await Task.Delay(1000);
            tbOpinionForAnamnesis.Text = "";
            await Task.Delay(1000);

        }
    }
}

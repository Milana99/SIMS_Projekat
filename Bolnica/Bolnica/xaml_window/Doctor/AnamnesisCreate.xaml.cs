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
    /// Interaction logic for AnamnesisCreate.xaml
    /// </summary>
    public partial class AnamnesisCreate : Window
    {
        AnamnesisTherapyAdd ata;
        MedicalRecordDoctor mrd;
        public AnamnesisCreate(MedicalRecordDoctor m)
        {
            InitializeComponent();
            mrd = m;
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            int id = mrd.anamControl.anamnesisService.anamnesisRepository.next_id;
            mrd.anamControl.anamnesisService.anamnesisRepository.next_id++;
            mrd.anamControl.CreateAnamnesis(mrd.lbuUsernamePatient.Content.ToString(), id,
                tbTypeAnamnesis.Text, tbDescriptionAnamnesis.Text, tbOpinionForAnamnesis.Text);
            
            for(int i =0; i<lvDataBindingAnamnesis.Items.Count;i++)
            {
                Model.Prescription prescription = (Model.Prescription)(lvDataBindingAnamnesis.Items[i]);
                mrd.pc.CreatePrescription(id, mrd.pc.prescriptionService.prescriptionRepository.next_id,
                    prescription.StartDatePrescription, prescription.EndDatePrescription, prescription.DescriptionPrescription,
                    prescription.QuantityPrescription, prescription.drug.DrugName);
            }
            mrd.Load();
            this.Close();
        }

        private void Button_Click_Therapy(object sender, RoutedEventArgs e)
        {
            ata = new AnamnesisTherapyAdd(mrd, this);
            ata.Show();
        }
    }
}

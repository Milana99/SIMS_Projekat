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
    /// Interaction logic for AnamnesisTherapyAdd.xaml
    /// </summary>
    public partial class AnamnesisTherapyAdd : Window
    {
        public MedicalRecordDoctor mrd;
        public AnamnesisCreate ac;
        public AnamnesisTherapyAdd(MedicalRecordDoctor m)
        {
            InitializeComponent();
            mrd = m;
            cbDrugAdd.Items.Add("Brufen");
            cbDrugAdd.Items.Add("Paracetamol");
            cbDrugAdd.Items.Add("Novi lek");
            cbDrugAdd.Items.Add("Magicni lek");
            cbDrugAdd.SelectedItem = "Brufen";
            lbDrugName.Content = mrd.pc.prescriptionService.prescriptionRepository.next_id.ToString();
            ac = null;
        }
        public AnamnesisTherapyAdd(MedicalRecordDoctor m, AnamnesisCreate a)
        {
            InitializeComponent();
            mrd = m;
            cbDrugAdd.Items.Add("Brufen");
            cbDrugAdd.Items.Add("Paracetamol");
            cbDrugAdd.Items.Add("Novi lek");
            cbDrugAdd.Items.Add("Magicni lek");
            cbDrugAdd.SelectedItem = "Brufen";
            lbDrugName.Content = mrd.pc.prescriptionService.prescriptionRepository.next_id.ToString();
            ac = a;
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            if(ac==null)
            {
                mrd.pc.CreatePrescription(((Model.Anamnesis)mrd.lvDataBinding.SelectedItems[0]).AnamnesisId,
                int.Parse(lbDrugName.Content.ToString()), Convert.ToDateTime(tbStartDate.Text), Convert.ToDateTime(tbEndDate.Text),
                tbDescriptionPrescription.Text, int.Parse(tbDrugQuantity.Text), cbDrugAdd.Text);
                mrd.full_uodate();
            }
            else
            {
                Model.Prescription prescription= new Model.Prescription(int.Parse(lbDrugName.Content.ToString()),
                    mrd.pc.prescriptionService.prescriptionRepository.next_id, Convert.ToDateTime(tbStartDate.Text),
                    Convert.ToDateTime(tbEndDate.Text), tbDescriptionPrescription.Text, int.Parse(tbDrugQuantity.Text), cbDrugAdd.Text);
                
                ac.lvDataBindingAnamnesis.Items.Add(prescription);
            }
            
            this.Close();
        }
    }
}

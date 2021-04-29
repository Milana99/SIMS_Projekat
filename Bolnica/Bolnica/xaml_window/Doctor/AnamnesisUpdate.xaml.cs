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
    /// Interaction logic for AnamnesisUpdate.xaml
    /// </summary>
    public partial class AnamnesisUpdate : Window
    {
        AnamnesisTherapyAdd at;
        MedicalRecordDoctor mrd;
        public AnamnesisUpdate(MedicalRecordDoctor m)
        {
            InitializeComponent();
            mrd = m;
            
        }

        private void Button_Click_Therapy(object sender, RoutedEventArgs e)
        {
            at = new AnamnesisTherapyAdd(mrd);
            at.Show();
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            Model.Anamnesis selected = (Model.Anamnesis)mrd.lvDataBinding.SelectedItems[0];
            mrd.anamControl.UpdateAnamnesis(selected.AnamnesisId, tbTypeAnamnesis.Text, tbDescriptionAnamnesis.Text, tbOpinionForAnamnesis.Text);
            mrd.Load();
            this.Close();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

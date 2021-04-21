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
    /// Interaction logic for MedicalRecordDoctor.xaml
    /// </summary>
    public partial class MedicalRecordDoctor : Window
    {
        AnamnesisOpen ao;
        AnamnesisCreate ac;
        AnamnesisUpdate au;
        public MedicalRecordDoctor()
        {
            InitializeComponent();
        }

        private void Button_Click_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Open_Anamnesis(object sender, RoutedEventArgs e)
        {
            ao = new AnamnesisOpen();
            ao.Show();
        }

        private void Button_Click_Update_Anamnesis(object sender, RoutedEventArgs e)
        {
            au = new AnamnesisUpdate();
            au.Show();
        }

        private void Button_Click_Create_Anamnesis(object sender, RoutedEventArgs e)
        {
            ac = new AnamnesisCreate();
            ac.Show();
        }
    }
}

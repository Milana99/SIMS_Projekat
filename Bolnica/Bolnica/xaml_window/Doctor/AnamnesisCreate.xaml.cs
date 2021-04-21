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
        AnamnesisTherapy ata;
        public AnamnesisCreate()
        {
            InitializeComponent();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Therapy(object sender, RoutedEventArgs e)
        {
            ata = new AnamnesisTherapy();
            ata.Show();
            this.Close();
        }
    }
}

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
    /// Interaction logic for DrugListVerify.xaml
    /// </summary>
    public partial class DrugListVerify : Window
    {
        public DrugListVerify()
        {
            InitializeComponent();
        }

        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {
            var dlvu = new DrugListVerifyEdit();
            dlvu.Show();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

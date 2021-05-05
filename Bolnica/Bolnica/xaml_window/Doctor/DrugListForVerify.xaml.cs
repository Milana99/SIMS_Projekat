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
    /// Interaction logic for DrugListForVerify.xaml
    /// </summary>
    public partial class DrugListForVerify : Window
    {
        public DrugListForVerify()
        {
            InitializeComponent();
        }

        private void Button_Click_In(object sender, RoutedEventArgs e)
        {
            var dlfvo = new DrugListForVerifyOne();
            dlfvo.Show();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

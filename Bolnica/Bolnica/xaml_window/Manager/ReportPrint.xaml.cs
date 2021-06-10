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

namespace Bolnica.xaml_window.Manager
{
    /// <summary>
    /// Interaction logic for ReportPrint.xaml
    /// </summary>
    public partial class ReportPrint : Window
    {
        public ReportPrint()
        {
            InitializeComponent();
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            var report = new Report();
            report.Show();
            this.Close();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            var report = new Report();
            report.Show();
            this.Close();
        }
    }
}

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
    
    public partial class LoginDoctor : Window
    {
        public MainWindow mw;
        public DoctorHome doctorHome;
        public LoginDoctor()
        {
            InitializeComponent();
        }

        private void Back_To_Main(object sender, RoutedEventArgs e)
        {
            mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void Doctor_Home(object sender, RoutedEventArgs e)
        {
            doctorHome = new DoctorHome();
            doctorHome.Show();
            this.Close(); 
        }
    }
}

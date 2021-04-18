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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bolnica
{

    public partial class MainWindow : Window
    {
        public xaml_window.Secretary.LoginSecretary loginSecretary;
        public xaml_window.Doctor.LoginDoctor loginDoctor;
        public xaml_window.Patient.LoginPatient loginPatient;
        public xaml_window.Manager.LoginManager loginManager;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Secretary_Button(object sender, RoutedEventArgs e)
        {
            loginSecretary = new xaml_window.Secretary.LoginSecretary();
            loginSecretary.Show();
            this.Close();
        }

        private void Patient_Button(object sender, RoutedEventArgs e)
        {
            loginPatient = new xaml_window.Patient.LoginPatient();
            loginPatient.Show();
            this.Close();
        }

        private void Manager_Button(object sender, RoutedEventArgs e)
        {
            loginManager = new xaml_window.Manager.LoginManager();
            loginManager.Show();
            this.Close();
        }

        private void Doctor_Button(object sender, RoutedEventArgs e)
        {
            loginDoctor = new xaml_window.Doctor.LoginDoctor();
            loginDoctor.Show();
            this.Close();
        }
    }
}

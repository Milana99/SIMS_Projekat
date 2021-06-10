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
            DeleteRenovations();
        }

        public void DeleteRenovations()
        {
            Controller.BasicRenovationController renovationController = new Controller.BasicRenovationController();
            DateTime now = DateTime.Now;
            List<Model.BasicRenovation> renovations = renovationController.GetAllRenovations();
            foreach(Model.Renovation renovation in renovations)
            {
                int comparation = DateTime.Compare(now, renovation.EndTime);
                if(comparation > 0)
                {
                    renovationController.DeleteRenovation(renovation.RenovationId);
                }
            }
        }

        private void Secretary_Button(object sender, RoutedEventArgs e)
        {
            var window1 = new Bolnica.xaml_window.Manager.Window1();
            window1.Show();
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

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
  
    public partial class LoginManager : Window
    {
        public MainWindow mw;
        public ManagerHome managerHome; 
        public LoginManager()
        {
            InitializeComponent();
        }

        private void Back_To_Main(object sender, RoutedEventArgs e)
        {
            mw = new MainWindow();
            mw.Show();
            this.Close();

        }

        private void Manager_Home(object sender, RoutedEventArgs e)
        {
            managerHome = new ManagerHome();
            managerHome.Show();
            this.Close();
        }
    }
}

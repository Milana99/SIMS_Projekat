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

namespace Bolnica.xaml_window.Secretary
{
    
    public partial class LoginSecretary : Window
    {
        public MainWindow mw;
        public SecretaryHome secretaryHome;
        public LoginSecretary()
        {
            InitializeComponent();
        }

        private void Secretary_Home(object sender, RoutedEventArgs e)
        {
            secretaryHome = new SecretaryHome();
            secretaryHome.Show();
            this.Close();
        }

        private void Back_To_Main(object sender, RoutedEventArgs e)
        {
            mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}

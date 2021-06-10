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
        string pass = "upravnik";
        string us = "Rasa";
        private string username;
        private string password;
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
            if (tbPassword.Password == pass && tbUsername.Text == us)
            {
                managerHome = new ManagerHome();
                managerHome.Show();
                this.Close();
            }
            else if(tbUsername.Text == us && tbPassword.Password!=pass)
            {
                tbPassword.BorderBrush = Brushes.Red;
                TestText.Text = "Pogrešna lozinka!";
                MessageBox.Show("Pogrešna lozinka!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else 
            {
                tbPassword.BorderBrush = Brushes.Red;
                tbUsername.BorderBrush = Brushes.Red;
                TestText.Text = "";
                MessageBox.Show("Pogrešno korisničko ime ili lozinka!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            
        }
    }
}

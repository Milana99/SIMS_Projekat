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
using System.ComponentModel;

namespace Bolnica.xaml_window.Doctor
{
    
    public partial class LoginDoctor : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public MainWindow mw;
        public DoctorHome doctorHome;
        string pass = "123";
        string us = "Milana123";
        private string username;
        private string password;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if (value != username)
                {
                    username = value;
                    OnPropertyChanged("Username");
                }

            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value != password)
                {
                    password = value;
                    OnPropertyChanged("Password");
                }

            }
        }
        public LoginDoctor()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Back_To_Main(object sender, RoutedEventArgs e)
        {
            mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void Doctor_Home(object sender, RoutedEventArgs e)
        {
            if (tbPassword.Password == pass && tbUsername.Text==us)
            {
                doctorHome = new DoctorHome();
                doctorHome.Show();
                this.Close();
            }
            else if(tbUsername.Text==us && tbPassword.Password!=pass)
            {
                tbPassword.BorderBrush = Brushes.Red;
                MessageBox.Show("Pogrešna lozinka!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else
            {
                tbPassword.BorderBrush = Brushes.Red;
                tbUsername.BorderBrush = Brushes.Red;
                MessageBox.Show("Pogrešno korisničko ime ili lozinka!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Error);
            }
                
        }
    }
}

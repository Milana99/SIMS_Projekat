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
    /// Interaction logic for ManagerHome.xaml
    /// </summary>
    public partial class ManagerHome : Window
    {
        public RoomList rl;
        MainWindow mw;
        public ManagerHome()
        {
            InitializeComponent();
        }

        private void Btn_Room_List(object sender, RoutedEventArgs e)
        {
            rl = new RoomList();
            rl.Show();
            this.Close();
        }

        private void Logout_Manager(object sender, RoutedEventArgs e)
        {
            mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}

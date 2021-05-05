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
    /// Interaction logic for DrugList.xaml
    /// </summary>
    public partial class DrugList : Window
    {
        public DrugList()
        {
            InitializeComponent();
        }

        private void Btn_Profile(object sender, RoutedEventArgs e)
        {
            var manager_profile = new ManagerHome();
            manager_profile.Show();
            this.Close();
        }

        private void Logout_Manager(object sender, RoutedEventArgs e)
        {
            var main_window = new MainWindow();
            main_window.Show();
            this.Close();
        }

        private void Button_Click_Room_List(object sender, RoutedEventArgs e)
        {
            var room_list = new RoomList();
            room_list.Show();
            this.Close();
        }

        private void Button_Click_Equipment_List(object sender, RoutedEventArgs e)
        {
            var equipment_list = new ListEquipment();
            equipment_list.Show();
            this.Close();
        }
    }
}

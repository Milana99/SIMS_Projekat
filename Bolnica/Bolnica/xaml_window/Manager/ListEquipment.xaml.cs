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
    /// Interaction logic for ListEquipment.xaml
    /// </summary>
    public partial class ListEquipment : Window
    {
        ManagerHome mh;
        RoomList rl;
        DynamicEquipment de;
        StaticEquipment se;
        public ListEquipment()
        {
            InitializeComponent();
        }

        private void Button_Click_Profile(object sender, RoutedEventArgs e)
        {
            mh = new ManagerHome();
            mh.Show();
            this.Close();
        }

        private void Button_Click_Room_List(object sender, RoutedEventArgs e)
        {
            rl = new RoomList();
            rl.Show();
            this.Close();
        }

        private void Button_Click_Dynamic_Equipment(object sender, RoutedEventArgs e)
        {
            de = new DynamicEquipment();
            de.Show();
            this.Close();
        }

        private void Button_Click_Static_Equipment(object sender, RoutedEventArgs e)
        {
            se = new StaticEquipment();
            se.Show();
            this.Close();
        }

        private void Logout_Manager(object sender, RoutedEventArgs e)
        {
            var main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Button_Click_Drug_List(object sender, RoutedEventArgs e)
        {
            var drug_list = new DrugList();
            drug_list.Show();
            this.Close();
        }

        private void Button_Click_Renovation(object sender, RoutedEventArgs e)
        {
            var renovation_list = new RenovationList();
            renovation_list.Show();
            this.Close();
        }

        private void Button_Click_Report(object sender, RoutedEventArgs e)
        {
            var report = new Report();
            report.Show();
            this.Close();
        }
    }
}

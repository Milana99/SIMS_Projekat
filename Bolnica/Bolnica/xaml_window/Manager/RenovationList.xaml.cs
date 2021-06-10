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
    /// Interaction logic for RenovationList.xaml
    /// </summary>
    public partial class RenovationList : Window
    {
        RoomList rl;
        RenovationAdd ra;
        public Controller.BasicRenovationController renovationController;
        public RenovationList()
        {
            InitializeComponent();
            renovationController = new Controller.BasicRenovationController();
            LoadAllRenovations();
        }

        public void LoadAllRenovations()
        {
            lvDataBindingRenovationList.Items.Clear();
            List<Model.BasicRenovation> renovations = renovationController.GetAllRenovations();
            foreach(Model.BasicRenovation renovation in renovations)
            {
                Console.WriteLine(renovation.room.RoomId);
                lvDataBindingRenovationList.Items.Add(renovation);
            }
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            rl = new RoomList();
            rl.Show();
            this.Close();
        }

        private void Button_Click_OK(object sender, RoutedEventArgs e)
        {
            ra = new RenovationAdd(this);
            ra.Show();
            this.Hide();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            Model.BasicRenovation renovation = (Model.BasicRenovation)lvDataBindingRenovationList.SelectedItems[0];
            renovationController.DeleteRenovation(renovation.RenovationId);
            LoadAllRenovations();
        }

        private void Button_Click_Profile(object sender, RoutedEventArgs e)
        {
            var maanager_home = new ManagerHome();
            maanager_home.Show();
            this.Close();
        }

        private void Button_Click_Drug_List(object sender, RoutedEventArgs e)
        {
            var drug_list = new DrugList();
            drug_list.Show();
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

        private void Logout_Manager(object sender, RoutedEventArgs e)
        {
            var main = new MainWindow();
            main.Show();
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

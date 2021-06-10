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
    /// Interaction logic for Report.xaml
    /// </summary>
    public partial class Report : Window
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Btn_Profile(object sender, RoutedEventArgs e)
        {
            var manager_profile = new ManagerHome();
            manager_profile.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
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

        private void Button_Click_renovation(object sender, RoutedEventArgs e)
        {
            var renovation_list = new RenovationList();
            renovation_list.Show();
            this.Close();
        }

        private void Logout_Manager(object sender, RoutedEventArgs e)
        {
            var main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (dtStart.Text == "")
            {
                MessageBox.Show("Niste popunili sva potrebna polja!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                var reportPrint = new ReportPrint();
                reportPrint.Show();
                for(int i = 0; i<lvDataBinding.Items.Count; i++)
                {
                    reportPrint.lvDataBinding.Items.Add(lvDataBinding.Items[i]);
                }
                reportPrint.lbDate.Content = DateTime.Now.Date;
                this.Close();
            }
        }

        private void dtStart_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Controller.RoomController roomController = new Controller.RoomController();
            Controller.BasicRenovationController renovationController = new Controller.BasicRenovationController();
            List<Model.Room> rooms;
            lvDataBinding.Items.Clear();
            foreach(Model.Room room in roomController.GetAllRooms())
            {
                bool add = true;
                foreach(Model.BasicRenovation renovation in renovationController.GetAllRenovations())
                {

                    if (room.RoomId == renovation.room.RoomId)
                    {
                        if ((DateTime.Compare(renovation.StartTime, DateTime.Parse(dtStart.SelectedDate.ToString())) <= 0) && (DateTime.Compare(renovation.EndTime, DateTime.Parse(dtStart.SelectedDate.ToString())) >= 0))
                        {
                            add = false;
                        }
                    }
                }
                if (add)
                {
                    room.free = "Slobodna";
                }
                else
                {
                    room.free = "Zauzeta";
                }
                lvDataBinding.Items.Add(room);
            }
        }
    }
}

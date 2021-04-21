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
    /// Interaction logic for StaticEquipmentCreate.xaml
    /// </summary>
    public partial class StaticEquipmentCreate : Window
    {
        public StaticEquipment se;
        public Controller.RoomController rc;
        public StaticEquipmentCreate(StaticEquipment s)
        {
            InitializeComponent();
            se = s;
            rc = new Controller.RoomController();
            List<Model.Room> rooms = rc.GetAllRooms();
            foreach(Model.Room r in rooms)
            {
                cbRoomStatic.Items.Add(r.RoomId);
            }
            cbRoomStatic.SelectedItem = cbRoomStatic.Items[0];
            lbIDStaticEq.Content = se.control.staticEquipmentService.staticEquipmentRepository.next_id;

        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            se.control.CreateStaticEquipment(int.Parse(lbIDStaticEq.Content.ToString()), tbStaticDescription.Text, int.Parse(cbRoomStatic.Text), tbName.Text);
            se.Load();
            this.Close();
        }
    }
}

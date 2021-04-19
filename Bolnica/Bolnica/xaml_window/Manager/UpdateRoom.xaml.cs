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
    /// Interaction logic for UpdateRoom.xaml
    /// </summary>
    public partial class UpdateRoom : Window
    {
        RoomList roomList;
        Model.Manager manager;
        public UpdateRoom(Model.Manager man, RoomList rl)
        {
            InitializeComponent();
            manager = man;
            roomList = rl;
            cbRoomType.Items.Add("Ordination");
            cbRoomType.Items.Add("HospitalRoom");
            cbRoomType.Items.Add("OperationRoom");
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            int rID = int.Parse(lbuID.Content.ToString());
            double area = double.Parse(tbuArea.Text);
            String description = tbuDescription.Text;
            Model.RoomType rt = (Model.RoomType)Enum.Parse(typeof(Model.RoomType), cbRoomType.Text);
            manager.Update(rID, description, area, rt);
            roomList.Load();
            this.Close();
        }
    }
}

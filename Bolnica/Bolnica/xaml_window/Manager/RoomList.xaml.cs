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
    /// Interaction logic for RoomList.xaml
    /// </summary>
    public partial class RoomList : Window
    {
        public ManagerHome mh;
        public CreateRoom cr;
        public UpdateRoom ur;
        public MainWindow mw;
        public Model.Manager manager;
        public List<Model.Room> rooms;
        public RoomList()
        {
            InitializeComponent();
            manager = new Model.Manager("Radovan");
            rooms = new List<Model.Room>();
            Load();
        }

        private void Logout_Manager(object sender, RoutedEventArgs e)
        {
            mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void Btn_Profile(object sender, RoutedEventArgs e)
        {
            mh = new ManagerHome();
            mh.Show();
            this.Close();
        }

        public void Load()
        {
            lvDataBinding.Items.Clear();
            manager.Load();
            rooms = manager.GetAllRooms();

            foreach (Model.Room r in rooms)
            {
                Console.WriteLine(r.RoomId);

                lvDataBinding.Items.Add(r);
            }

        }

        private void Update_room(object sender, RoutedEventArgs e)
        {
            ur = new UpdateRoom(manager, this);
            ur.Show();
            Model.Room selected = (Model.Room)lvDataBinding.SelectedItems[0];
            ur.lbuID.Content = selected.RoomId.ToString();
            ur.lbuFloor.Content = selected.Floor.ToString();
            ur.tbuArea.Text = selected.Area.ToString();
            ur.tbuDescription.Text = selected.Description;
            ur.cbRoomType.Text = selected.RoomType.ToString();

        }

        private void Delete_room(object sender, RoutedEventArgs e)
        {
            Model.Room selected = (Model.Room)lvDataBinding.SelectedItems[0];
            manager.RemoveRoom(selected.RoomId);
            Load();
        }

        private void Create_room(object sender, RoutedEventArgs e)
        {
            cr = new CreateRoom(this);
            cr.Show();
        }
    }
}

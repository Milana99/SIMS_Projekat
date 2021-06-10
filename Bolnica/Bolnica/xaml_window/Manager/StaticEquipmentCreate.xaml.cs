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

namespace Bolnica.xaml_window.Manager
{
    /// <summary>
    /// Interaction logic for StaticEquipmentCreate.xaml
    /// </summary>
    public partial class StaticEquipmentCreate : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public StaticEquipment se;
        public Controller.RoomController rc;
        private string name;
        private string description;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != name)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }

            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value != description)
                {
                    description = value;
                    OnPropertyChanged("Description");
                }

            }
        }
        public StaticEquipmentCreate(StaticEquipment s)
        {
            InitializeComponent();
            this.DataContext = this;
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
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da izađete?", "Zdravo", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
            return;
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            if (tbName.Text=="" || tbStaticDescription.Text=="" || cbRoomStatic.Text=="" )
            {
                MessageBox.Show("Niste popunili sva polja!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                se.control.CreateStaticEquipment(int.Parse(lbIDStaticEq.Content.ToString()), tbStaticDescription.Text, int.Parse(cbRoomStatic.Text), tbName.Text);
                se.LoadEqupiment();
                this.Close();
                MessageBox.Show("Uspešno ste kreirali statičku opremu!", "Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }
    }
}

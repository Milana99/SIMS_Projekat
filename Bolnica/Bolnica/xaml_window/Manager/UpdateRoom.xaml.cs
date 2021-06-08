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
    /// Interaction logic for UpdateRoom.xaml
    /// </summary>
    public partial class UpdateRoom : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        RoomList roomList;
        private string description;
        private int floor;
        private double area;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
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
        public int Floor
        {

            get
            {
                return floor;
            }
            set
            {
                if (value != floor)
                {
                    floor = value;
                    OnPropertyChanged("Floor");
                }

            }
        }
        public double Area
        {

            get
            {
                return area;
            }
            set
            {
                if (value != area)
                {
                    area = value;
                    OnPropertyChanged("Area");
                }

            }
        }
        public UpdateRoom(RoomList rl)
        {
            InitializeComponent();
            this.DataContext = this;
            roomList = rl;
            cbRoomType.Items.Add("Ordination");
            cbRoomType.Items.Add("HospitalRoom");
            cbRoomType.Items.Add("OperationRoom");
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da izađete?", "Zdravo", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
            {
                roomList = new RoomList();
                roomList.Show();
                this.Close();
            }
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            if (tbuDescription.Text == "" || tbuDescription.Text == null || tbuArea.Text == "" || tbuArea.Text == null ||
                cbRoomType.Text=="")
            {
                MessageBox.Show("Niste popunili sva polja!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                roomList = new RoomList();
                int rID = int.Parse(lbuID.Content.ToString());
                double area = double.Parse(tbuArea.Text);
                String description = tbuDescription.Text;
                Model.RoomType rt = (Model.RoomType)Enum.Parse(typeof(Model.RoomType), cbRoomType.Text);
                roomList.control.UpdateRoom(rID, description, area, rt);
                roomList.Load();
                roomList.Show();
                this.Close();
                MessageBox.Show("Uspešno ste izmenili salu!", "Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }
    }
}

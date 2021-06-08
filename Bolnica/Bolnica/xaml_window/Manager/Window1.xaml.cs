using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int colNum = 0;
        public List<Model.Room> Rooms;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        private double test1;
        private double test2;
        private string test3;
        public double Test1
        {
            get
            {
                return test1;
            }
            set
            {
                if(value!=test1)
                {
                    test1 = value;
                    OnPropertyChanged("Test1");
                }
                
            }
        }
        public double Test2
        {
            get
            {
                return test2;
            }
            set
            {
                if (value != test2)
                {
                    test2 = value;
                    OnPropertyChanged("Test2");
                }

            }
        }
        public string Test3
        {
            get
            {
                return test3;
            }
            set
            {
                if (value != test3)
                {
                    test3 = value;
                    OnPropertyChanged("Test3");
                }

            }
        }

        public Window1()
        {
            InitializeComponent();
            Rooms = new List<Model.Room>();
            Controller.RoomController control = new Controller.RoomController();
            Rooms = control.GetAllRooms();
            this.DataContext = this;
        }


        private void generatedColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                if (Rooms.Count > 0)
                {

                }
                else
                    MessageBox.Show("Nije moguce brisanje jer je tabela prazna!");
            
        }
    }
}

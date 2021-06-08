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
namespace Bolnica.xaml_window.Doctor
{
    /// <summary>
    /// Interaction logic for ExaminationUpdate.xaml
    /// </summary>
    public partial class ExaminationUpdate : Window, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        DoctorHome DoctorHome;
        CreateExaminationInventary CreateExaminationInvetory;
        private string start;
        private string end;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        public string Start
        {
            get
            {
                return start;
            }
            set
            {
                if (value != start)
                {
                    start = value;
                    OnPropertyChanged("Start");
                }

            }
        }
        public string End
        {
            get
            {
                return end;
            }
            set
            {
                if (value != end)
                {
                    end = value;
                    OnPropertyChanged("End");
                }

            }
        }



        public ExaminationUpdate(DoctorHome DoctorHome)
        {
            InitializeComponent();
            this.DoctorHome = DoctorHome;
            this.DataContext = this;
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da izađete?", "Zdravo", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
                this.Close();
            return;
        }

        private void Button_Click_OK(object sender, RoutedEventArgs e)
        {
            if (tbuStartTime.Text == "" || tbuEndTime.Text == "" || cbRoom.Text == "")
            {
                MessageBox.Show("Niste popunili sva polja!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                int exId = int.Parse(lbuID.Content.ToString());
                DateTime start = DateTime.Parse(DatePick.Text + " " + tbuStartTime.Text);
                DateTime end = DateTime.Parse(DatePick.Text + " " + tbuEndTime.Text);
                int roomId = int.Parse(cbRoom.Text);

                if (DoctorHome.ExaminationControl.UpdateExamination(exId, start, end, roomId))
                {
                    DoctorHome.LoadAll();
                    MessageBox.Show("Uspešno ste izmenili termin", "Uspešno!");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Izabrani termin je zauzet", "ERROR");
                }
            }
        }

        private void Button_Click_Inventary(object sender, RoutedEventArgs e)
        {
            if (cbRoom.Text == null || cbRoom.Text == "")
            {
                MessageBox.Show("Selektujte sobu pa pogledajte inventar!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                CreateExaminationInvetory = new CreateExaminationInventary(int.Parse(cbRoom.Text));
                CreateExaminationInvetory.Show();
            }
        }
    }
}

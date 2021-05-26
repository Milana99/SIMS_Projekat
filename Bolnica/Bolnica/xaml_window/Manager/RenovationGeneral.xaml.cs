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
    /// Interaction logic for RenovationGeneral.xaml
    /// </summary>
    public partial class RenovationGeneral : Window
    {
        RenovationAdd addRenovation;
        public Controller.RoomController roomController;
        public Controller.BasicRenovationController renovationController;
        public RenovationGeneral(RenovationAdd renovationAdd)
        {
            InitializeComponent();
            roomController = new Controller.RoomController();
            
            addRenovation = renovationAdd;
            renovationController = addRenovation.renovationController;
            LoadRooms();
        }
        public void LoadRooms()
        {
            List<Model.Room> rooms = roomController.GetAllRooms();
            foreach(Model.Room room in rooms)
            {
                cbRooms.Items.Add(room.RoomId) ;
            }
        }
        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            addRenovation.Show();
            this.Close();
        }

        private Model.BasicRenovation CreateRenovation()
        {
            Model.BasicRenovation renovation = new Model.BasicRenovation(renovationController.renovationService.renovationRepository.getNextRenovationId(),
                int.Parse(cbRooms.Text), DateTime.Parse(dpDateRenovationStart.Text + " " + tbStartTime.Text), DateTime.Parse(dpDateRenovationEnd.Text + " " + tbEndTime.Text),
                tbDescriptionRenovation.Text);
            return renovation;
        }
        private void Button_Click_OK(object sender, RoutedEventArgs e)
        {
            Model.BasicRenovation renovation = CreateRenovation();
            if(renovationController.renovationService.IsRoomFree(renovation.StartTime, renovation.EndTime, renovation.room.RoomId))
            {
                renovationController.CreateRenovation(renovation);
                addRenovation.Show();
                addRenovation.RenovationList.LoadAllRenovations();
                this.Close();
            }
            else
            {
                MessageBox.Show("Soba nije slobodna u izabranom terminu");
            }
            
        }
    }
}

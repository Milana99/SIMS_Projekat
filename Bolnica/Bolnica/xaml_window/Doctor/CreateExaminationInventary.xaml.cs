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

namespace Bolnica.xaml_window.Doctor
{
    /// <summary>
    /// Interaction logic for CreateExaminationInventary.xaml
    /// </summary>
    public partial class CreateExaminationInventary : Window
    {

        
        public Controller.StaticEquipmentController equipmentController;
        public CreateExaminationInventary(int roomId)
        {
            InitializeComponent();
            
            equipmentController = new Controller.StaticEquipmentController();
            lbExaminationRoomInventary.Content = roomId.ToString();
            LoadInvetory(roomId);
        }
        public void LoadInvetory(int roomId)
        {
            List<Model.StaticEquipment> equipments = equipmentController.GetAllStaticEquipmentForRoom(roomId);
            foreach(Model.StaticEquipment equipment in equipments)
            {
                lvDataBindingInventary.Items.Add(equipment);
            }
        }
        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }
    }
}

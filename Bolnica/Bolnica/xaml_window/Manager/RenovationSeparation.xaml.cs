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
    /// Interaction logic for RenovationDivision.xaml
    /// </summary>
    public partial class RenovationSeparation : Window
    {
        public RenovationSeparation()
        {
            InitializeComponent();
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            var renovation_add = new RenovationAdd();
            renovation_add.Show();
            this.Close();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            var renovation_add = new RenovationAdd();
            renovation_add.Show();
            this.Close();
        }

        private void Button_Click_Add_Room(object sender, RoutedEventArgs e)
        {
            var renovation_division_add_room = new RenovationSeparationRoomAdd();
            renovation_division_add_room.Show();
            this.Close();
        }
    }
}

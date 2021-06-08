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
    /// Interaction logic for StaticEquipmentRelocation.xaml
    /// </summary>
    public partial class StaticEquipmentRelocation : Window
    {
        public StaticEquipment se;
        public StaticEquipmentRelocation(StaticEquipment s)
        {
            InitializeComponent();
            se = s;
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
            if (dpRelocation.Text == "" || cbuRoomStatic.Text == "" )
            {
                MessageBox.Show("Niste popunili sva polja!", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                se.control.ChangeRoom(int.Parse(lbuIDStaticEq.Content.ToString()), int.Parse(cbuRoomStatic.Text));
                se.LoadEqupiment();
                this.Close();
            }
        }
    }
}

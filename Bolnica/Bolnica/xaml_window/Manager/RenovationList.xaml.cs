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
    /// Interaction logic for RenovationList.xaml
    /// </summary>
    public partial class RenovationList : Window
    {
        RoomList rl;
        RenovationAdd ra;
        public RenovationList()
        {
            InitializeComponent();
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            rl = new RoomList();
            rl.Show();
            this.Close();
        }

        private void Button_Click_OK(object sender, RoutedEventArgs e)
        {
            ra = new RenovationAdd();
            ra.Show();
            this.Close();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {

        }
    }
}

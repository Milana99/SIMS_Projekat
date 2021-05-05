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
    /// Interaction logic for RenovationAdd.xaml
    /// </summary>
    public partial class RenovationAdd : Window
    {
        public RenovationList RenovationList;
        RenovationGeneral rg;
        public Controller.RenovationController renovationController;
        public RenovationAdd(RenovationList renovationList)
        {
            InitializeComponent();
            this.RenovationList = renovationList;
            renovationController = RenovationList.renovationController;
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            
            RenovationList.Show();
            this.Close();
        }

        private void Button_Click_General(object sender, RoutedEventArgs e)
        {
            rg = new RenovationGeneral(this);
            rg.Show();
            this.Hide();
        }
    }
}

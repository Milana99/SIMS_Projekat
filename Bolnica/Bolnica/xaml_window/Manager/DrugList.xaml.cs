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
    /// Interaction logic for DrugList.xaml
    /// </summary>
    public partial class DrugList : Window
    {
        public Controller.DrugController drugController;
        public DrugList()
        {
            InitializeComponent();
            drugController = new Controller.DrugController();
            LoadAll();
            LoadTypes();
        }

        public void LoadAll()
        {
            lvDataBinding.Items.Clear();
            List<Model.Drug> drugs = drugController.GetAllDrugs();
            foreach (Model.Drug drug in drugs)
            {
                lvDataBinding.Items.Add(drug);
            }
            
        }

        private void Btn_Profile(object sender, RoutedEventArgs e)
        {
            var manager_profile = new ManagerHome();
            manager_profile.Show();
            this.Close();
        }

        private void Logout_Manager(object sender, RoutedEventArgs e)
        {
            var main_window = new MainWindow();
            main_window.Show();
            this.Close();
        }

        private void Button_Click_Room_List(object sender, RoutedEventArgs e)
        {
            var room_list = new RoomList();
            room_list.Show();
            this.Close();
        }

        private void Button_Click_Equipment_List(object sender, RoutedEventArgs e)
        {
            var equipment_list = new ListEquipment();
            equipment_list.Show();
            this.Close();
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            var drug_add = new DrugCreate(this);
            drug_add.Show();
            this.Hide();
        }

        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {
            var drug_update = new DrugUpdate(this);
            drug_update.Show();
           
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            Model.Drug drug = (Model.Drug)lvDataBinding.SelectedItems[0];
            drugController.DeleteDrug(drug.DrugId);
            LoadAll();
        }
        private void LoadTypes()
        {
            cbType.Items.Clear();
            cbType.Items.Add("Approved");
            cbType.Items.Add("NotApproved");
            cbType.Items.Add("Waiting");
            cbType.Items.Add("All");
            cbType.SelectedItem = "All";
        }
        private void TypeFilter()
        {
            lvDataBinding.Items.Clear();
            List<Model.Drug> drugs = drugController.GetAllDrugs();
            foreach(Model.Drug drug in drugs)
            {
                Console.WriteLine(drug.DrugType.ToString());
                Console.WriteLine(cbType.SelectedItem.ToString());
                if(drug.DrugType.ToString() == cbType.SelectedItem.ToString())
                {
                    lvDataBinding.Items.Add(drug);
                }
            }
        }
        private void cbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if(cbType.SelectedItem == "All")
            {
                LoadAll();
            }
            else
            {
                TypeFilter();
            }
        }
    }
}

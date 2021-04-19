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
    /// Interaction logic for DoctorHome.xaml
    /// </summary>
    public partial class DoctorHome : Window
    {
       public MainWindow mw;
        ExaminationUpdate eu;
        CreateExaminatio ce;

        public Model.Doctor doc;
        public List<Model.Examination> examinations;
        public DoctorHome()
        {
            InitializeComponent();
            doc = new Model.Doctor("Milana123");
            LoadAll();
            
        }

        public void LoadAll()
        {
            lvDataBinding.Items.Clear();
            doc.Load();
            examinations = doc.GetAllExaminations();

            foreach (Model.Examination ex in examinations)
            {
                lvDataBinding.Items.Add(ex);
            }
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            Model.Examination selected = (Model.Examination)lvDataBinding.SelectedItems[0];
            doc.RemoveExamination(selected.ExaminationId);
            LoadAll();
            MessageBox.Show("Uspešno ste izbrisali termin", "Uspešno!");
        }

        private void Button_Click_Create(object sender, RoutedEventArgs e)
        {
            ce = new CreateExaminatio(doc, this);
            ce.Show();
            
        }

        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {
            eu = new ExaminationUpdate(doc, this);
            eu.Show();
            Model.Examination selected = (Model.Examination)lvDataBinding.SelectedItems[0];
            eu.lbuID.Content = (selected.ExaminationId.ToString());
            eu.lbuPatient.Content = (selected.patient.User.Username);
            eu.tbuStartTime.Text = selected.StartTime.ToString();
            eu.tbuEndTime.Text = selected.EndTime.ToString();
        }

        private void Doctor_Logout(object sender, RoutedEventArgs e)
        {
            mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}

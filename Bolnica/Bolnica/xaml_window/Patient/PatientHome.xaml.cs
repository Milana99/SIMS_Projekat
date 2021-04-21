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

namespace Bolnica.xaml_window.Patient
{
    /// <summary>
    /// Interaction logic for PatientHome.xaml
    /// </summary>
    public partial class PatientHome : Window
    {
        public MainWindow mw;
        UpdateExamination ue;
        CreateExamination ce;

        public Model.Patient pat;
        public List<Model.Examination> examinations;


        public PatientHome()
        {
            InitializeComponent();
            pat = new Model.Patient("Jelena123");
            LoadAll();
        }

        public void LoadAll()
        {
            lvDataBinding.Items.Clear();
            pat.Load();
            examinations = pat.GetAllExaminations();

            foreach (Model.Examination ex in examinations)
            {
                lvDataBinding.Items.Add(ex);
            }

        }


        private void Button_Click_Create(object sender, RoutedEventArgs e)
        {
            ce = new CreateExamination(pat, this);
            ce.Show();
        }

        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {
            ue = new UpdateExamination(pat, this);
            ue.Show();
            Model.Examination selected = (Model.Examination)lvDataBinding.SelectedItems[0];
            DatePicker date = new DatePicker();




        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            Model.Examination selected = (Model.Examination)lvDataBinding.SelectedItems[0];
            pat.RemoveExaminations(selected.ExaminationId);
            LoadAll();
            MessageBox.Show("Uspešno ste izbrisali termin!");
        }


    }
}
﻿using System;
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
    /// Interaction logic for SpeialistExamination.xaml
    /// </summary>
    
    public partial class InstructionsForSpecialistExamination : Window
    {
        MedicalRecordDoctor MedicalRecordDoctor;
        public Controller.InstrucitonsForSpecialisticExaminationController SpecialisticExaminationController;
        public InstructionsForSpecialistExamination(MedicalRecordDoctor medicalRecord)
        {
            InitializeComponent();
            MedicalRecordDoctor = medicalRecord;
            LoadSpecialist();
            lblPatientsName.Content = MedicalRecordDoctor.lbuUsernamePatient.Content;
            SpecialisticExaminationController = new Controller.InstrucitonsForSpecialisticExaminationController();
        }

        

        public void LoadSpecialist()
        {
            cbSpecialist.Items.Add("Grgeč");
            cbSpecialist.Items.Add("Slaviček");
            cbSpecialist.Items.Add("Kunić");
            cbSpecialist.Items.Add("Primarijus");
        }

        public Model.InstructionsForSpecialistExamination CreateSpecialistExamination()
        {
            Model.InstructionsForSpecialistExamination specialistExamination = new Model.InstructionsForSpecialistExamination(SpecialisticExaminationController.specialisticExaminationService.specialisticExaminationRepository.getNextId(),
                cbSpecialist.Text.ToString() , lblDoctorsName.Content.ToString(), lblPatientsName.Content.ToString(), tbComment.Text.ToString());
            return specialistExamination;
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Model.InstructionsForSpecialistExamination specialistExamination = CreateSpecialistExamination();
            SpecialisticExaminationController.CreateSpecialisticExamination(specialistExamination);
            this.Close();

        }
    }
}
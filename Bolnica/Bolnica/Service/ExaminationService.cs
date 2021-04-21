using System.Collections.Generic;
using System;
using Bolnica.Model;
using Bolnica.xaml_window.Doctor;

namespace Bolnica.Service
{
   public class ExaminationService
   {
        
        public Bolnica.Repository.ExaminationRepository examinationRepository;



        public ExaminationService()
        {
            examinationRepository = new Repository.ExaminationRepository(@"C:\Users\pc\OneDrive\Radna površina\GitBolnica\SIMS_Projekat\Bolnica\Doktor.txt");
        }

        public List<Model.Examination> GetAllExaminations()
        {
            return examinationRepository.LoadExamination();
            
        }
      

      public Model.Examination GetOneExamination(int examinationId)
      {
            List<Model.Examination> examinations = GetAllExaminations();
            foreach(Model.Examination ex in examinations)
            {
                if(ex.ExaminationId == examinationId)
                {
                    return ex;
                }
            }
            return null;
      }

      public Boolean CompareTime(DateTime newTime1, DateTime newTime2, int id)
      {
            List<Model.Examination> examinations = GetAllExaminations();
            foreach (Examination ex in examinations)
            {
                //if(((ex.StartTime<=newTime1) && (ex.EndTime>newTime1)) || ((ex.StartTime<newTime2)&&(ex.EndTime>=newTime2)))
                int start1 = DateTime.Compare(ex.StartTime, newTime1);
                int start2 = DateTime.Compare(ex.EndTime, newTime1);
                int end1 = DateTime.Compare(ex.StartTime, newTime2);
                int end2 = DateTime.Compare(ex.EndTime, newTime2);

                if (id != ex.ExaminationId)
                {
                    if ((start1 <= 0 && start2 >= 0) || (end1 <= 0 && end2 >= 0) || (start1 >= 0 && end2 <= 0))
                    {
                        return false;
                    }
                }

            }
            return true;
      }

      public Boolean CreateExamination(int examinationId, DateTime startTime, DateTime endTime, Model.ExaminationType examinationType, String doctorUsername, String patientUsername, int room)
      {
            List<Model.Examination> examinations = GetAllExaminations();
            Examination newExamination = new Examination(examinationId, startTime, endTime, doctorUsername, patientUsername, room);
            Boolean a = CompareTime(startTime, endTime, examinationId);
            
            if (a == true)
            {
                examinations.Add(newExamination);
                examinationRepository.SaveExamination(examinations);
                return true;
            }
            return false;
        }
      
      public void DeleteExamination(int examinationId)
      {
            List<Model.Examination> examinations = GetAllExaminations();
            foreach(Examination ex in examinations)
            {
                if(ex.ExaminationId == examinationId)
                {
                    ex.DeleteExamination();
                    examinationRepository.SaveExamination(examinations);
                    return;
                }
                
            }
        }
      
      public Boolean UpdateExamination(int examinationId, DateTime startTime, DateTime endTime)
      {
            List<Model.Examination> examinations = GetAllExaminations();

            foreach (Examination ex in examinations)
            {
                if (ex.ExaminationId == examinationId && ex.deleted == false)
                {

                    Boolean cmp = CompareTime(startTime, endTime, examinationId);

                    if (cmp == true)
                    {
                        ex.StartTime = startTime;
                        ex.EndTime = endTime;

                        examinationRepository.SaveExamination(examinations);
                        return true;
                    }
                    else
                        return false;
                }
            }
            return false;
        }
      
      public List<Model.Examination> GetExaminatonsForDoctor(String doctorUsername)
      {
            List<Model.Examination> examinations = GetAllExaminations();
            List<Model.Examination> newExaminations = new List<Model.Examination>();

            foreach (Model.Examination ex in examinations)
            {
                if (ex.doctor.User.Username == doctorUsername)
                {
                    newExaminations.Add(ex);
                }
            }
            return newExaminations;
        }
      
      public List<Model.Examination> GetExaminationForPatient(String patientUsername)
      {
            List<Model.Examination> examinations = GetAllExaminations();
            List<Model.Examination> newExaminations = new List<Model.Examination>();

            foreach (Model.Examination ex in examinations)
            {
                if (ex.patient.User.Username == patientUsername)
                {
                    newExaminations.Add(ex);
                }
            }
            return newExaminations;
        }
      
      public void NotifyPatientBySecretary(String patientEmail)
      {
         // TODO: implement
      }
      
      public void NotifyDoctorBySecretary(String doctorEmail)
      {
         // TODO: implement
      }
   
 
   
   }
}
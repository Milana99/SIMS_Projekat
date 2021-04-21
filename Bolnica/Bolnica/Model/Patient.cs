using System;
using System.Collections.Generic;

namespace Bolnica.Model
{
   public class Patient
   {
        public User User { get; set; }
        public List<Examination> examinations { get; set; }
        private int Lbo { get; set; }
        private int Bzk { get; set; }

        public ExaminationFileStorage efs;

        public Patient(String newUsername)
        {
            User = new User(newUsername);
        }

        public List<Examination> GetAllExaminations()
        {
             return examinations;
        }
  
      public List<Examination> GetExaminations()
      {
         if (examinations == null)
            examinations = new List<Examination>();
         return examinations;
      }

      public void SetExaminations(System.Collections.ArrayList newExaminations)
      {
         RemoveAllExaminations();
         foreach (Examination oExamination in newExaminations)
            AddExaminations(oExamination);
      }
      

      public Boolean AddExaminations(Examination newExamination)
      {
            Boolean a = CompareTime(newExamination.StartTime, newExamination.EndTime, newExamination.ExaminationId);
            if (a == true)
            {
                examinations.Add(newExamination);
                efs.Save(examinations);
                examinations = efs.Load(@"C:\Users\Jelena\Desktop\GITBOLNICA\SIMS_Projekat\Bolnica\Bolnica\Patient.txt");
                return true;
            }


            return false;
        }

      public Boolean CompareTime(DateTime newTime1, DateTime newTime2, int id)
        {
            foreach (Examination ex in examinations)
            {
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
      
      public void RemoveExaminations(int exId)
      {
            foreach (Examination ex in examinations)
            {
                if (exId == ex.ExaminationId)
                {
                    ex.DeleteExamination();
                }
            }

            efs.Save(examinations);
            efs.Load(@"C:\Users\Jelena\Desktop\GITBOLNICA\SIMS_Projekat\Bolnica\Bolnica\Patient.txt");

        }
      
      public void RemoveAllExaminations()
      {
         
      }

        public Boolean Update(int examinationId, DateTime newDate, DateTime newStartTime, DateTime newEndTime)
        {
            foreach (Examination ex in examinations)
            {
                if (ex.ExaminationId == examinationId && ex.deleted == false)
                {
                    Boolean cmp = CompareTime(newStartTime, newEndTime, examinationId);

                    if (cmp == true)
                    {
                        ex.StartTime = newStartTime;
                        ex.EndTime = newEndTime;

                        efs.Save(examinations);
                        efs.Load(@"C:\Users\Jelena\Desktop\GITBOLNICA\SIMS_Projekat\Bolnica\Bolnica\Patient.txt");
                        return true;
                    }
                    else
                        return false;
                }
            }
            return false;

        }

        public void Load()
        {
            efs = new ExaminationFileStorage();
            examinations = efs.Load(@"C:\Users\Jelena\Desktop\GITBOLNICA\SIMS_Projekat\Bolnica\Bolnica\Patient.txt");

        }


    }
}
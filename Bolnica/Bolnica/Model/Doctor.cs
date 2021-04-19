using System;
using System.Collections.Generic;
using System.Globalization;

namespace Bolnica.Model
{
   public class Doctor : Employee
   {


        public TypeOfSpetialization typeOfSpetialization { get; set; }
        public List<Examination> examinations { get; set; }
        public ExaminationFileStorage exm;
        
        public Doctor(User newUser, double newSalary, double newWorkingHours, TypeOfSpetialization newTypeOfSpetialization) : base(newUser, newSalary, newWorkingHours)
        {
            typeOfSpetialization = newTypeOfSpetialization;
            
        }

        public Doctor(String newUsername) : base(newUsername)
        {
            
        }
        
        
        public void Load()
        {
            exm = new ExaminationFileStorage();
            examinations = exm.Load(@"C:\Users\pc\OneDrive\Radna površina\GitBolnica\SIMS_Projekat\Bolnica\Doktor.txt");
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
      
      public Boolean AddExaminations(Examination newExamination)
      {
            Boolean a = CompareTime(newExamination.StartTime, newExamination.EndTime, newExamination.ExaminationId);
            if(a == true)
            {
                examinations.Add(newExamination);
                exm.Save(examinations);
                examinations = exm.Load(@"C:\Users\pc\OneDrive\Radna površina\GitBolnica\SIMS_Projekat\Bolnica\Doktor.txt");
                return true;
            }
            return false;
                        
      }
      

          public void RemoveExamination(int exId)
          {
                foreach(Examination ex in examinations)
                {
                    if(exId == ex.ExaminationId)
                    {
                        ex.DeleteExamination();
                    }
                }
                exm.Save(examinations);
                exm.Load(@"C:\Users\pc\OneDrive\Radna površina\GitBolnica\SIMS_Projekat\Bolnica\Doktor.txt");
          }

        public Boolean Update(int examenationId, DateTime newStartTime, DateTime newEndTime)
        {
            foreach (Examination ex in examinations)
            {
                if (ex.ExaminationId == examenationId && ex.deleted == false)
                {
                    
                    Boolean cmp = CompareTime(newStartTime, newEndTime, examenationId);

                    if (cmp == true)
                    {
                        ex.StartTime = newStartTime;
                        ex.EndTime = newEndTime;

                        exm.Save(examinations);
                        exm.Load(@"C:\Users\pc\OneDrive\Radna površina\GitBolnica\SIMS_Projekat\Bolnica\Doktor.txt");
                        return true;
                    }
                    else
                        return false;
                }
            }
            return false;
        }

        public Boolean CompareTime(DateTime newTime1, DateTime newTime2, int id)
        {
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

        
   
   }
}
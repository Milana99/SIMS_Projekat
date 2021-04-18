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

        public List<Examination> GetAllExaminations()
      {
         // TODO: implement
         return null;
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
      

      public void AddExaminations(Examination newExamination)
      {
         if (newExamination == null)
            return;
         if (this.examinations == null)
            this.examinations = new List<Examination>();
         if (!this.examinations.Contains(newExamination))
         {
            this.examinations.Add(newExamination);
            newExamination.SetPatient(this);      
         }
      }
      
      public void RemoveExaminations(Examination oldExamination)
      {
         if (oldExamination == null)
            return;
         if (this.examinations != null)
            if (this.examinations.Contains(oldExamination))
            {
               this.examinations.Remove(oldExamination);
               oldExamination.SetPatient((Patient)null);
            }
      }
      
      public void RemoveAllExaminations()
      {
         if (examinations != null)
         {
            System.Collections.ArrayList tmpExaminations = new System.Collections.ArrayList();
            foreach (Examination oldExamination in examinations)
               tmpExaminations.Add(oldExamination);
            examinations.Clear();
            foreach (Examination oldExamination in tmpExaminations)
               oldExamination.SetPatient((Patient)null);
            tmpExaminations.Clear();
         }
      }
     
   
   }
}
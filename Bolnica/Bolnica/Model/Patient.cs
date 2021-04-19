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


        public Patient(String newUsername)
        {
            User = new User(newUsername);
        }

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
         
      }
      
      public void RemoveExaminations(Examination oldExamination)
      {
         
      }
      
      public void RemoveAllExaminations()
      {
         
      }
     
   
   }
}
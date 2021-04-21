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
        public Patient(String UserName, String name, String surname, String mail, DateTime dob, Gender gend, long jmbg, String address,
            String tel, int lbo, int bzk)
        {
            User = new User(name, surname, UserName, "123", tel, mail, gend, jmbg, dob, address);
            Lbo = lbo;
            Bzk = bzk;
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
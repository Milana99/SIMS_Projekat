using System;
using System.Collections.Generic;
using System.Globalization;

namespace Bolnica.Model
{
   public class Doctor : Employee
   {


        public TypeOfSpetialization typeOfSpetialization { get; set; }
        public List<Examination> examinations { get; set; }

        public Doctor(User newUser, double newSalary, double newWorkingHours, TypeOfSpetialization newTypeOfSpetialization) : base(newUser, newSalary, newWorkingHours)
        {
            typeOfSpetialization = newTypeOfSpetialization;
        }

        public Doctor(String newUsername) : base(newUsername)
        {

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
         if (newExamination == null)
            return;
         if (this.examinations == null)
            this.examinations = new List<Examination>();
         if (!this.examinations.Contains(newExamination))
         {
            this.examinations.Add(newExamination);
            newExamination.SetDoctor(this);      
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
               oldExamination.SetDoctor((Doctor)null);
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
               oldExamination.SetDoctor((Doctor)null);
            tmpExaminations.Clear();
         }
      }
   
   }
}
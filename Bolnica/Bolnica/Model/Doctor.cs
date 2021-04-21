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
        
        
        public void Load()
        {
            
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
   }
}
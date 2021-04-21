using System;
using System.Collections.Generic;

namespace Bolnica.Controller
{
   public class DoctorController
   {
        public Bolnica.Service.DoctorService doctorService;
        public List<Model.Doctor> GetAllDoctor()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor GetOneDoctor(String username)
      {
         // TODO: implement
         return null;
      }
      
      public void CreateDoctor(String name, String surname, String username, String password, String phoneNumber, String email, Model.Gender gender, long jmbg, DateTime dateOfBirth, String address, Model.TypeOfSpetialization typeOfSpecialiyation)
      {
         // TODO: implement
      }
      
      public void DeleteDoctor(String username)
      {
         // TODO: implement
      }
      
      public void UpdateDoctor(String name, String surname, String phoneNumber, String email, String address)
      {
         // TODO: implement
      }
   
      
   
   }
}
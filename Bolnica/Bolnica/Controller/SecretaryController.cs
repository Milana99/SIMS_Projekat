using System;
using System.Collections.Generic;
namespace Bolnica.Controller
{
   public class SecretaryController
   {
        public Bolnica.Service.SecretaryService secretaryService;
        public List<Model.Secretary> GetAllSecretary()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Secretary GetOneSecretary(String username)
      {
         // TODO: implement
         return null;
      }
      
      public void CreateSecretary(String name, String surname, String username, String password, String phoneNumber, String email, Model.Gender gender, long jmbg, DateTime dateOfBirth, String address)
      {
         // TODO: implement
      }
      
      public void DeleteSecretary(String username)
      {
         // TODO: implement
      }
      
      public void UpdateSecretary(String name, String surname, String phoneNumber, String email, String address)
      {
         // TODO: implement
      }
   

   
   }
}
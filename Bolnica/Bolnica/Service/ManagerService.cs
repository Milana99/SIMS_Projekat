using System;
using System.Collections.Generic;

namespace Bolnica.Service
{
   public class ManagerService
   {
        public Bolnica.Repository.ManagerRepository managerRepository;
        public List<Model.Manager> GetAllManagers()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Manager GetOneManager(String username)
      {
         // TODO: implement
         return null;
      }
      
      public void CreateManager(String name, String surname, String username, String password, String phoneNumber, String email, Model.Gender gender, long jmbg, DateTime dateOfBirth, String address)
      {
         // TODO: implement
      }
      
      public void DeleteManager(String username)
      {
         // TODO: implement
      }
      
      public void UpdateManager(String name, String surname, String phoneNumber, String email, String address)
      {
         // TODO: implement
      }
   

   
   }
}
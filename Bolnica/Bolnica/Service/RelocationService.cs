using System;
using System.Collections.Generic;

namespace Bolnica.Service
{
   public class RelocationService
   {
        public Bolnica.Repository.RelocationRepository relocationRepository;
        public List<Model.Relocation> GetAllRelocationService()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Relocation GetOneRelocationService(int relocationId)
      {
         // TODO: implement
         return null;
      }
      
      public void CreateRelocationService(int relocationId, DateTime dateRelocation, Model.Room room, Model.StaticEquipment staticEquipment)
      {
         // TODO: implement
      }
      
      public void UpdateRelocationService(int relocationId, DateTime dateRelocation)
      {
         // TODO: implement
      }
      
      public void DeleteRelocationService(int reloctionId)
      {
         // TODO: implement
      }
   

   
   }
}
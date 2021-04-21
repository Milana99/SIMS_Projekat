using System;
using System.Collections.Generic;

namespace Bolnica.Service
{
   public class StaticEquipmentService
   {
        public Bolnica.Repository.StaticEquipmentRepository staticEquipmentRepository;
        public List<Model.StaticEquipment> GetAllEquipment()
      {
         // TODO: implement
         return null;
      }
      
      public Model.StaticEquipment GetOneStaticEquipment(int staticEquipmentId)
      {
         // TODO: implement
         return null;
      }
      
      public void CreateStaticEquipment(int staticEquipmentId, int quantity, String description, String type, String name)
      {
         // TODO: implement
      }
      
      public void DeleteStaticEquipment(int staticEquipmentId)
      {
         // TODO: implement
      }
      
      public void UpdateStaticEquipment(int staticEquipmentId, int quantity, int description, int name)
      {
         // TODO: implement
      }
      
      public List<Model.StaticEquipment> GetAllEquipmentForRoom(int roomId)
      {
         // TODO: implement
         return null;
      }
   
 
   
   }
}
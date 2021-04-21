using System;
using System.Collections.Generic;

namespace Bolnica.Controller
{
   public class StaticEquipmentController
   {
        public Bolnica.Service.StaticEquipmentService staticEquipmentService;

        public StaticEquipmentController()
        {
            staticEquipmentService = new Service.StaticEquipmentService();
        }
        public List<Model.StaticEquipment> GetAllEquipment()
      {

            return staticEquipmentService.GetAllEquipment();
      }
      
      public Model.StaticEquipment GetOneStaticEquipment(int staticEquipmentId)
      {
            return staticEquipmentService.GetOneStaticEquipment(staticEquipmentId);
      }
      
      public void CreateStaticEquipment(int staticEquipmentId, String description, int roomId, String name)
      {
            staticEquipmentService.CreateStaticEquipment(staticEquipmentId, description, roomId, name);
      }
      
      public void DeleteStaticEquipment(int staticEquipmentId)
      {
            staticEquipmentService.DeleteStaticEquipment(staticEquipmentId);
      }
      
      public void UpdateStaticEquipment(int staticEquipmentId, String description, String name)
      {
            staticEquipmentService.UpdateStaticEquipment(staticEquipmentId, description, name);
      }
      
      public List<Model.StaticEquipment> GetAllStaticEquipmentForRoom(int roomId)
      {
            return staticEquipmentService.GetAllEquipmentForRoom(roomId);
      }
   
    
   
   }
}
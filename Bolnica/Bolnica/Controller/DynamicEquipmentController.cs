using System;
using System.Collections.Generic;

namespace Bolnica.Controller
{
   public class DynamicEquipmentController
   {
        public Bolnica.Service.DynamicEquipmentService dynamicEquipmentService;

        public DynamicEquipmentController()
        {
            dynamicEquipmentService = new Service.DynamicEquipmentService();
        }

        public List<Model.DynamicEquipment> GetAllDynamicEquipments()
      {
            return dynamicEquipmentService.GetAllDynamicEquipments();
      }
      
      public Model.DynamicEquipment GetOneDynamicEquipment(int dinamicEquipmentId)
      {
            return dynamicEquipmentService.GetOneDynamicEquipment(dinamicEquipmentId);
      }
      
      public void CreateDynamicEquipment(int dynamicEquipmentId, int quantity, String name)
      {
            dynamicEquipmentService.CreateDynamicEquipment(dynamicEquipmentId, quantity, name);
      }
      
      public void UpdateDynamicEquipment(int dynamicEquipmentId, int quantity, String name)
      {
            dynamicEquipmentService.UpdateDynamicEquipment(dynamicEquipmentId, quantity, name);
      }
      
      public void DeleteDynamicEquipment(int dynamicEquipmentId)
      {
            dynamicEquipmentService.DeleteDynamicEquipment(dynamicEquipmentId);
      }
   

   
   }
}
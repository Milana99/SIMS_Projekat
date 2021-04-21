using System;
using System.Collections.Generic;

namespace Bolnica.Service
{
   public class DynamicEquipmentService
   {

        public Bolnica.Repository.DynamicEquipmentRepository dynamicEquipmentRepository;

        public DynamicEquipmentService()
        {
            dynamicEquipmentRepository = new Repository.DynamicEquipmentRepository(@"C:\Users\pc\OneDrive\Radna površina\Radovan\Upravnik\Dynamic.txt");
        }
        public List<Model.DynamicEquipment> GetAllDynamicEquipments()
      {
            return dynamicEquipmentRepository.LoadDynamicEquipment();
      }
      
      public Model.DynamicEquipment GetOneDynamicEquipment(int dinamicEquipmentId)
      {
            List<Model.DynamicEquipment> equipments = GetAllDynamicEquipments();
            foreach(Model.DynamicEquipment de in equipments)
            {
                if(de.DynamicEquipmentId==dinamicEquipmentId)
                {
                    return de;
                }
            }
            return null;
      }
      
      public void CreateDynamicEquipment(int dynamicEquipmentId, int quantity, String name)
      {
            List<Model.DynamicEquipment> equipments = GetAllDynamicEquipments();
            Model.DynamicEquipment newEquipment = new Model.DynamicEquipment(dynamicEquipmentId, 
                quantity, name);
            equipments.Add(newEquipment);
            dynamicEquipmentRepository.SaveDynamicEquipment(equipments);

      }
      
      public void UpdateDynamicEquipment(int dynamicEquipmentId, int quantity, String name)
      {
            List<Model.DynamicEquipment> equipments = GetAllDynamicEquipments();
            foreach(Model.DynamicEquipment de in equipments)
            {
                if(de.DynamicEquipmentId == dynamicEquipmentId)
                {
                    de.DynamicEquipmentQuantity = quantity;
                    de.DynamicEquipmentName = name;
                    dynamicEquipmentRepository.SaveDynamicEquipment(equipments);
                    return;
                }
            }
           
      }
      
      public void DeleteDynamicEquipment(int dynamicEquipmentId)
      {
            List<Model.DynamicEquipment> equipments = GetAllDynamicEquipments();
            foreach (Model.DynamicEquipment de in equipments)
            {
                if (de.DynamicEquipmentId == dynamicEquipmentId)
                {
                    de.Delete();
                    dynamicEquipmentRepository.SaveDynamicEquipment(equipments);
                }
            }
        }
   
   
   }
}
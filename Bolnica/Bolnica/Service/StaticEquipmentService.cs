using System;
using System.Collections.Generic;

namespace Bolnica.Service
{
   public class StaticEquipmentService
   {
        public Bolnica.Repository.StaticEquipmentRepository staticEquipmentRepository;

        public StaticEquipmentService()
        {
            staticEquipmentRepository = new Repository.StaticEquipmentRepository(@"C:\Users\pc\OneDrive\Radna površina\Radovan\Upravnik\Static.txt");
        }
        public List<Model.StaticEquipment> GetAllEquipment()
        {
            return staticEquipmentRepository.LoadStaticEquipment();
        }
      
      public Model.StaticEquipment GetOneStaticEquipment(int staticEquipmentId)
      {
            List<Model.StaticEquipment> equipments = GetAllEquipment();
            foreach (Model.StaticEquipment ste in equipments)
            {
                if(staticEquipmentId == ste.StaticEquipmentId)
                {
                    return ste;
                }
            }
            return null;
      }
      
      public void CreateStaticEquipment(int staticEquipmentId, String description, int roomId, String name)
      {
            List<Model.StaticEquipment> equipments = GetAllEquipment();
            Model.StaticEquipment ste = new Model.StaticEquipment(staticEquipmentId, name, description, roomId);
            equipments.Add(ste);
            staticEquipmentRepository.SaveStaticEquipment(equipments);
      }
      
      public void DeleteStaticEquipment(int staticEquipmentId)
      {
            List<Model.StaticEquipment> equipments = GetAllEquipment();
            foreach(Model.StaticEquipment ste in equipments)
            {
                if (ste.StaticEquipmentId == staticEquipmentId)
                {
                    ste.Delete();
                    staticEquipmentRepository.SaveStaticEquipment(equipments);
                    return;
                }
            }
      }
      
      public void UpdateStaticEquipment(int staticEquipmentId, String description, String name)
      {
            List<Model.StaticEquipment> equipments = GetAllEquipment();
            foreach (Model.StaticEquipment ste in equipments)
            {
                if (ste.StaticEquipmentId == staticEquipmentId)
                {
                    ste.DescriptionStaticEquipment = description;
                    ste.NameStaticEquipment = name;
                    staticEquipmentRepository.SaveStaticEquipment(equipments);
                    return;
                }
            }
        }

        public void ChangeRoom(int staticEquipmentId, int roomId)
        {
            List<Model.StaticEquipment> equipments = GetAllEquipment();
            foreach (Model.StaticEquipment ste in equipments)
            {
                if(ste.StaticEquipmentId == staticEquipmentId)
                {
                    ste.roomStaticEquipment.RoomId = roomId;
                    staticEquipmentRepository.SaveStaticEquipment(equipments);
                    return;
                }
            }
        }
      
      public List<Model.StaticEquipment> GetAllEquipmentForRoom(int roomId)
      {
            List<Model.StaticEquipment> equipments = GetAllEquipment();
            List<Model.StaticEquipment> RoomEquipments = new List<Model.StaticEquipment>();

            foreach(Model.StaticEquipment ste in equipments)
            {
                if (ste.roomStaticEquipment.RoomId == roomId)
                {
                    RoomEquipments.Add(ste);
                }
               
            }
            return RoomEquipments;
        }
   
 
   
   }
}
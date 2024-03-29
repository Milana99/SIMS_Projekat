using System;
using System.Collections.Generic;

namespace Bolnica.Service
{
   public class StaticEquipmentService
   {
        public Bolnica.Repository.StaticEquipmentRepository staticEquipmentRepository;

        public StaticEquipmentService()
        {
            staticEquipmentRepository = new Repository.StaticEquipmentRepository(@"C:\Users\pc\OneDrive\Radna povr�ina\Radovan\Upravnik\Static.txt");
        }
        public List<Model.StaticEquipment> GetAllEquipment()
        {
            return staticEquipmentRepository.Load();
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
            staticEquipmentRepository.Save(equipments);
      }
      
      public void DeleteStaticEquipment(int staticEquipmentId)
      {
            List<Model.StaticEquipment> equipments = GetAllEquipment();
            foreach(Model.StaticEquipment ste in equipments)
            {
                if (ste.StaticEquipmentId == staticEquipmentId)
                {
                    ste.Delete();
                    staticEquipmentRepository.Save(equipments);
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
                    staticEquipmentRepository.Save(equipments);
                    return;
                }
            }
        }
        public void UpdateStaticEquipment(int staticEquipmentId, String description, String name, bool free)
      {
            List<Model.StaticEquipment> equipments = GetAllEquipment();
            foreach (Model.StaticEquipment ste in equipments)
            {
                if (ste.StaticEquipmentId == staticEquipmentId)
                {
                    ste.free = free;
                    ste.DescriptionStaticEquipment = description;
                    ste.NameStaticEquipment = name;
                    staticEquipmentRepository.Save(equipments);
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
                    staticEquipmentRepository.Save(equipments);
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
        
        public void changeRoomFromRoom(int newRoomId, int oldRoomId)
        {
            List<Model.StaticEquipment> equipments = GetAllEquipment();
            foreach(Model.StaticEquipment equipment in equipments)
            {
                if(equipment.roomStaticEquipment.RoomId == oldRoomId)
                {
                    equipment.ChangeRoom(newRoomId);
                }
            }
            staticEquipmentRepository.Save(equipments);
        }
 
   
   }
}
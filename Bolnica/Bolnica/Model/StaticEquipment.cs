using System;

namespace Bolnica.Model
{
   public class StaticEquipment
   {
        public Room roomStaticEquipment { get; set; }

        public int StaticEquipmentId { get; set; }
        public String DescriptionStaticEquipment { get; set; }
        public String NameStaticEquipment { get; set; }

        public bool free;

        public Boolean deleted;

        public StaticEquipment(int id, String Name, String Description, int roomId)
        {
            StaticEquipmentId = id;
            NameStaticEquipment = Name;
            DescriptionStaticEquipment = Description;
            roomStaticEquipment = new Room(roomId);
            free = true;
            deleted = false;
        }
        public StaticEquipment(int id, String Name, String Description, int roomId, bool free)
        {
            StaticEquipmentId = id;
            NameStaticEquipment = Name;
            DescriptionStaticEquipment = Description;
            roomStaticEquipment = new Room(roomId);
            this.free = free;
            deleted = false;
        }

        public void Delete()
        {
            deleted = true;
        }
        public void ChangeRoom(int newRoom)
        {
            roomStaticEquipment = new Room(newRoom);
        }
    }
}
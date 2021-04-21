using System;

namespace Bolnica.Model
{
   public class DynamicEquipment
   {
        public int DynamicEquipmentId { get; set; }
        public int DynamicEquipmentQuantity { get; set; }
        public String DynamicEquipmentName { get; set; }

        public bool deleted;

        public DynamicEquipment(int EquipmentId, int Quantity, String EquipmentName)
        {
            DynamicEquipmentId = EquipmentId;
            DynamicEquipmentQuantity = Quantity;
            DynamicEquipmentName = EquipmentName;
            deleted = false;
        }

        public void Delete()
        {
            deleted = true;
        }

    }
}
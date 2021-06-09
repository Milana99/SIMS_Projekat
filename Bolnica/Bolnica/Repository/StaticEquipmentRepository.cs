using System;
using System.Collections.Generic;
using System.IO;

namespace Bolnica.Repository
{
   public class StaticEquipmentRepository : Repository<Model.StaticEquipment>
   {

        public int next_id;

        public StaticEquipmentRepository(String fileLocation) : base(fileLocation) { }

        public override Model.StaticEquipment addOne(string[] words)
        {
            Model.StaticEquipment ste = new Model.StaticEquipment(int.Parse(words[0]),
                        words[1], words[2], int.Parse(words[3]), bool.Parse(words[4]));
            next_id = ste.StaticEquipmentId;
            next_id++;
            return ste;
        }

        public override String getOne(Model.StaticEquipment staticEquipment)
        {
            if (staticEquipment.deleted == false)
            {
                String line = staticEquipment.StaticEquipmentId.ToString() + "," + staticEquipment.NameStaticEquipment + ","
                        + staticEquipment.DescriptionStaticEquipment + ","
                        + staticEquipment.roomStaticEquipment.RoomId.ToString() + "," + staticEquipment.free.ToString();
                return line;
            }
            return null;
        }
   
   }
}
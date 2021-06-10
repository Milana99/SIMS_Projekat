using Bolnica.Model;
using System;

namespace Bolnica.Repository
{
    public class BasicRenovationRepository : Repository<Model.BasicRenovation>
    {

        public int renovationId;
        public BasicRenovationRepository(String fileLocation) : base(fileLocation) { }

        public override BasicRenovation addOne(string[] words)
        {
            renovationId = int.Parse(words[0]);
            Model.BasicRenovation renovation = new Model.BasicRenovation(int.Parse(words[0]), int.Parse(words[1]),
                       DateTime.Parse(words[2]), DateTime.Parse(words[3]), words[4]);

            return renovation;
        }
        
        public override String getOne(BasicRenovation renovation)
        {
            if (renovation.deleted == false)
            {
                String line = renovation.RenovationId.ToString() + "," + renovation.room.RoomId + "," +
                        renovation.StartTime.ToString() + "," + renovation.EndTime.ToString() + "," + renovation.RenovationDescription;
                return line;
            }
            return null;
        }
        public int getNextRenovationId()
        {
            renovationId++;
            return renovationId;
        }


    }
}
/***********************************************************************
 * Module:  Renovation.cs
 * Author:  pc
 * Purpose: Definition of the Class Bolnica.Model.Renovation
 ***********************************************************************/

using System;

namespace Bolnica.Model
{
    public class Renovation
    {
        public Room room { get; set; }
        public int RenovationId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public String RenovationDescription { get; set; }
        public bool deleted { get; set; }

        public Renovation(int RenovationId, int RoomId, DateTime Start, DateTime End, String Description)
        {
            this.RenovationId = RenovationId;
            StartTime = Start;
            EndTime = End;
            RenovationDescription = Description;
            room = new Room(RoomId);
            deleted = false;
        }

    }
}
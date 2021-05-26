/***********************************************************************
 * Module:  BasicRenovation.cs
 * Author:  pc
 * Purpose: Definition of the Class Bolnica.Model.BasicRenovation
 ***********************************************************************/

using System;

namespace Bolnica.Model
{
   public class BasicRenovation : Renovation
   {
        public Room room { get; set; }
        public String RenovationDescription { get; set; }
        public BasicRenovation(int RenovationId, int RoomId, DateTime Start, DateTime End, String Description):base(RenovationId,Start,End)
        {
            RenovationDescription = Description;
            room = new Room(RoomId);
        }

    }
}
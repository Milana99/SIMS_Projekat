/***********************************************************************
 * Module:  RoomSeparation.cs
 * Author:  pc
 * Purpose: Definition of the Class Bolnica.Model.RoomSeparation
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace Bolnica.Model
{
    public class RoomSeparation : Renovation
    {
        public Room RoomForSeparation;
        public List<Room> newRooms;
        public RoomSeparation(int RenovationId, Room roomForSeparation, List<Room> newRooms , DateTime Start, DateTime End, String Description) : base(RenovationId, Start, End)
        {
            this.RoomForSeparation = roomForSeparation;
            this.newRooms = newRooms;
        }

    }
}
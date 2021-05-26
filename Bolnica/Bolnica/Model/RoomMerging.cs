/***********************************************************************
 * Module:  RoomMerging.cs
 * Author:  pc
 * Purpose: Definition of the Class Bolnica.Model.RoomMerging
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace Bolnica.Model
{
   public class RoomMerging : Renovation
   {
      public Room[] RoomsForMerging;

        public Room newRoom { get; set; }
        public List<Room> rooms;     
        public bool deleted { get; set; }
        public RoomMerging(int RenovationId, Room newRoom, List<Room> rooms, DateTime Start, DateTime End) : base(RenovationId, Start, End)
        {
            this.newRoom = newRoom;
            this.rooms = rooms;
        }

    }
}
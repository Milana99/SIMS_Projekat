/***********************************************************************
 * Module:  RoomMergingController.cs
 * Author:  pc
 * Purpose: Definition of the Class Bolnica.Controller.RoomMergingController
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace Bolnica.Controller
{
   public class RoomSeparationController
   {
      public void CreateRoomSeparation(Bolnica.Model.Room roomForSeparation, List<Model.Room> newRooms)
      {
         // TODO: implement
      }
      
      public void UpdateRoomSeparation(int roomSeparationId, List<Model.Room> newRooms)
      {
         // TODO: implement
      }
      
      public void DeleteRoomSeparation(int roomSeparationId)
      {
         // TODO: implement
      }
      
      public List<Model.RoomMerging> GetAllRoomSeparation()
      {
         // TODO: implement
         return null;
      }
      
      public Model.RoomSeparation GetOneRoomSeparation(int roomSeparationId)
      {
         // TODO: implement
         return null;
      }
   
      public Bolnica.Service.RoomSeparationService roomSeparationService;
   
   }
}
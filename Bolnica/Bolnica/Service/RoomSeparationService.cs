/***********************************************************************
 * Module:  RoomSeparationService.cs
 * Author:  pc
 * Purpose: Definition of the Class Bolnica.Service.RoomSeparationService
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace Bolnica.Service
{
   public class RoomSeparationService
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
   
      public Bolnica.Repository.RoomSeparationRepository roomSeparationRepository;
   
   }
}
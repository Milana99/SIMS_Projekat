/***********************************************************************
 * Module:  Class45.cs
 * Author:  pc
 * Purpose: Definition of the Class Bolnica.Controller.Class45
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace Bolnica.Service
{
   public class RoomMergingService
   {
      public void CreateRoomMerging(List<Model.Room> roomsForMerging, Bolnica.Model.Room newRoom)
      {
         // TODO: implement
      }
      
      public void UpdateRoomMerging(int roomMergingId, Bolnica.Model.Room newRoom)
      {
         // TODO: implement
      }
      
      public void DeleteRoomMerging(int roomMergingId)
      {
         // TODO: implement
      }
      
      public List<Model.RoomMerging> GetAllRoomMergings()
      {
         // TODO: implement
         return null;
      }
      
      public Model.RoomMerging GetOneRoomMergingById(int roomMergingId)
      {
         // TODO: implement
         return null;
      }
   
      public Bolnica.Repository.RoomMergingRepository roomMergingRepository;
   
   }
}
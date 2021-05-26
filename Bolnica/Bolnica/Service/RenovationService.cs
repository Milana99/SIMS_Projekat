/***********************************************************************
 * Module:  RenovationService.cs
 * Author:  pc
 * Purpose: Definition of the Class Bolnica.Service.RenovationService
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Bolnica.Model;

namespace Bolnica.Service
{
   public class RenovationService
   {
      public Renovation GetOneRenovation(int renovationId)
      {
         // TODO: implement
         return null;
      }
      
      public List<Renovation> GetAllRenovations()
      {
         // TODO: implement
         return null;
      }
      
      public void CreateRenovation(Renovation renovation)
      {
         // TODO: implement
      }
      
      public void DeleteRenovation(int renovationId)
      {
         // TODO: implement
      }
      
      public void UpdateRenovation(Renovation renovation)
      {
         // TODO: implement
      }
      
      public bool IsRoomFree(DateTime newStartTime, DateTime newEndTime, int roomId)
      {
         // TODO: implement
         return false;
      }
      
      public bool IsRoomFreeRenovation(DateTime newStartTime, DateTime newEndTime, int roomId)
      {
         // TODO: implement
         return false;
      }
      
      public bool IsRoomFreeExamination(DateTime newStartTime, DateTime newEndTime, int roomId)
      {
         // TODO: implement
         return false;
      }
   
      public Bolnica.Repository.RenovationRepository renovationRepository;
   
   }
}
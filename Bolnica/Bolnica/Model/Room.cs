using System;
using System.Collections.Generic;


namespace Bolnica.Model
{
   public class Room
   {
        public List<Examination> examinations;
        private int RoomId;
        private String Description;
        private double Floor;
        private double Area;
        private RoomType RoomType;
        public bool deleted;

        public Room(int newRoomId, String newDescription, double newFloor, double newArea, RoomType newRoomType)
        {
            RoomId = newRoomId;
            Description = newDescription;
            Floor = newFloor;
            Area = newArea;
            RoomType = newRoomType;
            deleted = false;
        }
        
        public void SaveRoom(int roomId, int description, int floor, int area, int roomType)
      {
         // TODO: implement
      }
      
      public void DeleteRoom()
      {
         // TODO: implement
      }
      
      public void UpdateRoom(int description, int area, int roomType)
      {
         // TODO: implement
      }
      
      public Room GetRoom()
      {
         // TODO: implement
         return null;
      }
  
      public List<Examination> GetExamination()
      {
         if (examinations == null)
            examinations = new List<Examination>();
         return examinations;
      }
      

      public void SetExamination(System.Collections.ArrayList newExamination)
      {
         RemoveAllExamination();
         foreach (Examination oExamination in newExamination)
            AddExamination(oExamination);
      }
      

      public void AddExamination(Examination newExamination)
      {
         
      }
      

      public void RemoveExamination(Examination oldExamination)
      {
         
      }
      

      public void RemoveAllExamination()
      {
         
      }
   
   }
}
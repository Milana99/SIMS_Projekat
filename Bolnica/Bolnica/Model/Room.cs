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
         if (newExamination == null)
            return;
         if (this.examinations == null)
            this.examinations = new List<Examination>();
         if (!this.examinations.Contains(newExamination))
         {
            this.examinations.Add(newExamination);
            newExamination.SetRoom(this);      
         }
      }
      

      public void RemoveExamination(Examination oldExamination)
      {
         if (oldExamination == null)
            return;
         if (this.examinations != null)
            if (this.examinations.Contains(oldExamination))
            {
               this.examinations.Remove(oldExamination);
               oldExamination.SetRoom((Room)null);
            }
      }
      

      public void RemoveAllExamination()
      {
         if (examinations != null)
         {
            System.Collections.ArrayList tmpExamination = new System.Collections.ArrayList();
            foreach (Examination oldExamination in examinations)
               tmpExamination.Add(oldExamination);
            examinations.Clear();
            foreach (Examination oldExamination in tmpExamination)
               oldExamination.SetRoom((Room)null);
            tmpExamination.Clear();
         }
      }
   
   }
}
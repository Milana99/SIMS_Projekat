using System;
using System.Collections.Generic;

namespace Bolnica.Model
{
   public class Manager : Employee
   {
      public List<Room> Room;
      public RoomFileStorage rfs;

        public Manager(User newUser, double newSalary, double newWorkingHours) : base(newUser, newSalary, newWorkingHours) { }

        public Manager(String userName) : base(userName)
        {
            Room = new List<Room>();
        }

        public void Load()
        {
           
        }

        

        public List<Room> GetAllRooms()
        {
            return Room;
        }


    }
}
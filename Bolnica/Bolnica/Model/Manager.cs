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
            rfs = new RoomFileStorage();
            Room = rfs.Load(@"C:\Users\pc\OneDrive\Radna površina\Radovan\Upravnik\Upravnik.txt");
        }

        public void Update(int roomId, String newDescription, double newArea, RoomType newRoomType)
        {
            foreach (Room r in Room)
            {
                if (r.RoomId == roomId)
                {
                    r.Description = newDescription;
                    r.Area = newArea;
                    r.RoomType = newRoomType;
                    r.RoomType = newRoomType;
                    rfs.Save(Room);
                    Room = rfs.Load(@"C:\Users\pc\OneDrive\Radna površina\Radovan\Upravnik\Upravnik.txt");
                    return;
                }
            }

        }

        public void AddRoom(Room newRoom)
        {
            Room.Add(newRoom);
            rfs.Save(Room);
            Room = rfs.Load(@"C:\Users\pc\OneDrive\Radna površina\Radovan\Upravnik\Upravnik.txt");
        }

        public void RemoveRoom(int roId)
        {
            foreach (Room r in Room)
            {
                if (r.RoomId == roId)
                {
                    r.DeleteRoom();
                    rfs.Save(Room);
                    Room = rfs.Load(@"C:\Users\Radovan\Downloads\Upravnik\Upravnik.txt");
                    return;
                }
            }

        }

        public List<Room> GetAllRooms()
        {
            return Room;
        }


    }
}
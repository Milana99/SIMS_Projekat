using System;
using System.Collections.Generic;

namespace Bolnica.Model
{
   public class Manager : Employee
   {
      public List<Room> rooms;
        public RoomFileStorage rfs;
        
        public Manager(User newUser, double newSalary, double newWorkingHours) : base(newUser, newSalary, newWorkingHours) 
        {
            
        }
        public Manager(String userName) : base(userName) 
        { 
            rooms = new List<Room>();
        }
        
        public void Load()
        {
            rfs = new RoomFileStorage();
            rooms = rfs.Load(@"C:\Users\Radovan\Downloads\Upravnik\Upravnik.txt");
        }

        public void Update(int roomId, String newDescription, double newArea, RoomType newRoomType)
        {
            foreach(Room r in rooms)
            {
                if(r.RoomId == roomId)
                {
                    r.Description = newDescription;
                    r.Area = newArea;
                    r.RoomType = newRoomType;
                    r.RoomType = newRoomType;
                    rfs.Save(rooms);
                    rooms = rfs.Load(@"C:\Users\Radovan\Downloads\Upravnik\Upravnik.txt");
                    return;
                }
            }

        }
        
        public void AddRoom(Room newRoom)
        {
            rooms.Add(newRoom);
            rfs.Save(rooms);
            rooms = rfs.Load(@"C:\Users\Radovan\Downloads\Upravnik\Upravnik.txt");
        }

        public void RemoveRoom(int roId)
        {
            foreach(Room r in rooms)
            {
                if(r.RoomId == roId)
                {
                    r.DeleteRoom();
                    rfs.Save(rooms);
                    rooms = rfs.Load(@"C:\Users\Radovan\Downloads\Upravnik\Upravnik.txt");
                    return;
                }
            }

        }

        public List<Room> GetAllRooms()
        {
            return rooms;
        }

    }
}
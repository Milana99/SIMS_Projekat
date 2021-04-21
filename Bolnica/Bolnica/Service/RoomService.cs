using System;
using System.Collections.Generic;
namespace Bolnica.Service
{
   public class RoomService
   {
        public Bolnica.Repository.RoomRepository roomRepository;

        public RoomService()
        {
            roomRepository = new Repository.RoomRepository(@"C:\Users\pc\OneDrive\Radna površina\Radovan\Upravnik\Upravnik.txt");
        }
        public List<Model.Room> GetAllRooms()
        {
            return roomRepository.LoadRoom();
        }
      
      public Model.Room GetByIdRoom(int roomId)
      {
            List<Model.Room> rooms = GetAllRooms();
            foreach(Model.Room r in rooms)
            {
                if(r.RoomId == roomId)
                {
                    return r;
                }
            }
         return null;
      }
      
      public void CreateRoom(int roomId, String description, int floor, double area, Model.RoomType roomType)
      {
            List<Model.Room> rooms = GetAllRooms();
            Model.Room newRoom = new Model.Room(roomId, description, floor, area, roomType);
            rooms.Add(newRoom);
            roomRepository.SaveRoom(rooms);
        }
      
      public void DeleteRoom(int roomId)
      {
            List<Model.Room> rooms = GetAllRooms();
            foreach(Model.Room r in rooms)
            {
                if (r.RoomId == roomId)
                {
                    r.DeleteRoom();
                    roomRepository.SaveRoom(rooms);
                    return;
                }
                
            }
        }
      
      public void UpdateRoom(int roomId, String description, double area, Model.RoomType roomType)
      {
            List<Model.Room> rooms = GetAllRooms();
            foreach(Model.Room r in rooms)
            {
                if(r.RoomId == roomId)
                {
                    r.Description = description;
                    r.Area = area;
                    r.RoomType = roomType;
                    roomRepository.SaveRoom(rooms);
                    return;
                }
            }
      }
      
      public List<Model.Room> GetAllRoomsByType(Model.RoomType roomType)
      {
            List<Model.Room> rooms = GetAllRooms();
            List<Model.Room> roomsOfType = new List<Model.Room>();
            foreach (Model.Room r in rooms)
            {
                if(r.RoomType == roomType)
                {
                    roomsOfType.Add(r);
                }
            }
            return roomsOfType;
        }
   

   
   }
}
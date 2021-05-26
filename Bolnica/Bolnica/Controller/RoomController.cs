using System;
using System.Collections.Generic;

namespace Bolnica.Controller
{
    public class RoomController
    {
        public Bolnica.Service.RoomService roomService;
        public RoomController()
        {
            roomService = new Service.RoomService();
        }
        public List<Model.Room> GetAllRooms()
        {
            return roomService.GetAllRooms();
        }

        public Model.Room GetByIdRoom(int roomId)
        {
            return roomService.GetByIdRoom(roomId);
        }

        public void CreateRoom(Model.Room newRoom)
        {
            roomService.CreateRoom(newRoom);
        }

        public void DeleteRoom(int roomId)
        {
            roomService.DeleteRoom(roomId);
        }

        public void UpdateRoom(int roomId, String description, double area, Model.RoomType roomType)
        {
            roomService.UpdateRoom(roomId, description, area, roomType);
        }

        public List<Model.Room> GetAllRoomsByType(Model.RoomType roomType)
        {
            return roomService.GetAllRoomsByType(roomType);
        }
        
        public int getNextId()
        {
            return roomService.getNextId();
        }
    }
}
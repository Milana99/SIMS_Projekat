using System;
using System.Collections.Generic;
using System.IO;

namespace Bolnica.Repository
{
    public class RoomRepository
    {
        private String FileLocation { get; set; }
        public int next_roomID;

        public RoomRepository(String newFileLocation)
        {
            FileLocation = newFileLocation;
        }

        public int getNextId()
        {
            int prim=next_roomID;
            next_roomID++;
            return prim;
        }
        public List<Model.Room> LoadRoom()
        {
            List<Model.Room> rooms = new List<Model.Room>();
            try
            {
                String line;
                StreamReader sr = new StreamReader(FileLocation);

                while ((line = sr.ReadLine()) != null)
                {

                    string[] words = line.Split(',');

                    Model.Room ro = new Model.Room(int.Parse(words[0]), words[1], int.Parse(words[2]),
                        double.Parse(words[3]), (Model.RoomType)Enum.Parse(typeof(Model.RoomType), words[4]));

                    rooms.Add(ro);

                    next_roomID = ro.RoomId;

                }
                next_roomID++;

                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            return rooms;
        }


        public void SaveRoom(List<Model.Room> roomList)
        {
            File.Delete(FileLocation);
            String line;
            List<String> lines = new List<String>();

            foreach (Model.Room r in roomList)
            {
                if (r.deleted == false)
                {
                    line = r.RoomId.ToString() + "," + r.Description + "," + r.Floor.ToString() + "," + r.Area.ToString() + "," + r.RoomType.ToString();
                    lines.Add(line);
                }
            }
            File.WriteAllLines(FileLocation, lines);
        }

        public void DeleteRooms()
        {
            File.Delete(FileLocation);
        }


    }
}
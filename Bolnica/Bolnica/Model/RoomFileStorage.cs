using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Globalization;

namespace Bolnica.Model
{
   public class RoomFileStorage
   {

        private String FileLocation;
        public int next_roomID;


        public List<Room> Load(string fileLocation)
        {
            FileLocation = fileLocation;
            List<Room> rooms = new List<Room>();

            try
            {
                String line;
                StreamReader sr = new StreamReader(FileLocation);

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    string[] words = line.Split(',');
                    

                    Room ro = new Room(int.Parse(words[0]), words[1], double.Parse(words[2]), 
                        double.Parse(words[3]), (RoomType)Enum.Parse(typeof(RoomType), words[4]));

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
      
      public void Save(List<Room> roomList)
      {
            File.Delete(FileLocation);
            String line;
            List<String> lines = new List<String>();
            
            foreach(Room r in roomList)
            {
                if(r.deleted == false)
                {
                    line = r.RoomId.ToString() + "," + r.Description + "," + r.Floor.ToString() + "," + r.Area.ToString() + "," + r.RoomType.ToString();
                    lines.Add(line);
                }
            }
            File.WriteAllLines(FileLocation, lines);
        }
      
      public void Delete()
      {
            File.Delete(FileLocation);
      }
   
   
   }
}
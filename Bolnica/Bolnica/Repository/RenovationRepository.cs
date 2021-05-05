using System.Collections.Generic;
using System;
using Bolnica.Model;
using System.IO;

namespace Bolnica.Repository
{
   public class RenovationRepository
   {

      private String FileLocation { get; set; }
      private int renovationId;

      public RenovationRepository(String fileLocation)
        {
            FileLocation = fileLocation;
        }
      public List<Renovation> LoadRenovation()
      {
            List<Model.Renovation> renovations = new List<Model.Renovation>();
            try
            {
                String line;
                StreamReader sr = new StreamReader(FileLocation);

                while ((line = sr.ReadLine()) != null)
                {

                    string[] words = line.Split(',');
                    Model.Renovation renovation = new Model.Renovation(int.Parse(words[0]), int.Parse(words[1]),
                        DateTime.Parse(words[2]), DateTime.Parse(words[3]), words[4]);
                    renovations.Add(renovation);

                    renovationId = int.Parse(words[0]);
                }
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

            return renovations;
        }
      
      public void SaveRenovation(List<Renovation> renovationList)
      {
            File.Delete(FileLocation);
            String line;
            List<String> lines = new List<String>();

            foreach (Model.Renovation renovation in renovationList)
            {
                if (renovation.deleted == false)
                {
                    line = renovation.RenovationId.ToString() + "," + renovation.room.RoomId + "," +
                        renovation.StartTime.ToString() + "," + renovation.EndTime.ToString() + "," + renovation.RenovationDescription;

                    lines.Add(line);
                }
            }
            File.WriteAllLines(FileLocation, lines);
        }

      public int getNextRenovationId()
        {
            renovationId++;
            return renovationId;
        }
      
      public void DeleteRenovation()
      {
            File.Delete(FileLocation);
      }
   
      
   
   }
}
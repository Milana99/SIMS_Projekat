using System;
using System.Collections.Generic;
using System.IO;

namespace Bolnica.Repository
{
   public class StaticEquipmentRepository
   {

        private String FileLocation;
        public int next_id;

        public StaticEquipmentRepository(String fileLocation)
        {
            FileLocation = fileLocation;
        }
        public List<Model.StaticEquipment> LoadStaticEquipment()
        {
            List<Model.StaticEquipment> equipments = new List<Model.StaticEquipment>();

            try
            {
                String line;
                StreamReader sr = new StreamReader(FileLocation);

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    string[] words = line.Split(',');

                    Model.StaticEquipment ste = new Model.StaticEquipment(int.Parse(words[0]), 
                        words[1], words[2], int.Parse(words[3]), bool.Parse(words[4]));


                    equipments.Add(ste);
                    next_id = ste.StaticEquipmentId;

                }
                next_id++;

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

            return equipments;
        }
      
      public void SaveStaticEquipment(List<Model.StaticEquipment> staticEquipmentList)
      {
            File.Delete(FileLocation);
            String line;
            List<String> lines = new List<String>();

            foreach (Model.StaticEquipment ste in staticEquipmentList)
            {
                if (ste.deleted == false)
                {
                    line = ste.StaticEquipmentId.ToString() + "," + ste.NameStaticEquipment + ","
                        + ste.DescriptionStaticEquipment + "," 
                        + ste.roomStaticEquipment.RoomId.ToString() +"," + ste.free.ToString();
                    
                    lines.Add(line);
                }
            }
            File.WriteAllLines(FileLocation, lines);
        }
      
      public void DeleteStaticEquipments()
      {
            File.Delete(FileLocation);
      }
   
   }
}
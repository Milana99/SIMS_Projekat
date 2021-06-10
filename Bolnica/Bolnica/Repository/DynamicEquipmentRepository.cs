using System;
using System.Collections.Generic;
using System.IO;

namespace Bolnica.Repository
{
    public class DynamicEquipmentRepository : IRepo<Model.DynamicEquipment>
    {

        private String FileLocation;
        public int next_id;

        public DynamicEquipmentRepository(String fileLocation)
        {
            FileLocation = fileLocation;
        }

        public List<Model.DynamicEquipment> Load()
        {
            List<Model.DynamicEquipment> equipments = new List<Model.DynamicEquipment>();

            try
            {
                String line;
                StreamReader sr = new StreamReader(FileLocation);

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    string[] words = line.Split(',');

                    Model.DynamicEquipment de = new Model.DynamicEquipment(int.Parse(words[0]),
                        int.Parse(words[1]), words[2]);

                    equipments.Add(de);
                    next_id = de.DynamicEquipmentId;

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

        public void Save(List<Model.DynamicEquipment> dynamicEquipmentList)
        {
            File.Delete(FileLocation);
            String line;
            List<String> lines = new List<String>();

            foreach (Model.DynamicEquipment de in dynamicEquipmentList)
            {
                if (de.deleted == false)
                {
                    line = de.DynamicEquipmentId.ToString() + ","
                        + de.DynamicEquipmentQuantity.ToString() + "," + de.DynamicEquipmentName;

                    lines.Add(line);
                }
            }
            File.WriteAllLines(FileLocation, lines);
        }

        public int getNextId()
        {
            int s = next_id;
            next_id++;
            return s;
        }

        public void Delete()
        {
            File.Delete(FileLocation);
        }

        


    }
}
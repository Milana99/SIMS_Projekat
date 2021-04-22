using System;
using System.Collections.Generic;
using System.IO;

namespace Bolnica.Repository
{
   public class TherapyRepository
   {
        private String FileLocation;
        public int next_id;
        public TherapyRepository(String fileLocation)
        {
            FileLocation = fileLocation;
        }
        public List<Model.Therapy> LoadTherapy()
      {
            List<Model.Therapy> therapies = new List<Model.Therapy>();

            try
            {
                String line;
                StreamReader sr = new StreamReader(FileLocation);

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    string[] words = line.Split(',');


                    Model.Therapy th = new Model.Therapy(int.Parse(words[0]), int.Parse(words[1]), words[2]);

                    therapies.Add(th);

                    next_id = th.TherapyId;

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

            return therapies;
        }
      
      public void SaveTherapy(List<Model.Therapy> thearpyList)
      {
            File.Delete(FileLocation);
            String line;
            List<String> lines = new List<String>();

            foreach (Model.Therapy th in thearpyList)
            {
                if (th.deleted == false)
                {
                    line = th.anamnesis.AnamnesisId.ToString() + "," + th.TherapyId.ToString() + "," + th.Description;
                    lines.Add(line);
                }
            }
            File.WriteAllLines(FileLocation, lines);
        }
      
      public void DeleteTherapies()
      {
            File.Delete(FileLocation);
       }
   
   
   }
}
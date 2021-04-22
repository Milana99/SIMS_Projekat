using System;
using System.Collections.Generic;
using System.IO;
namespace Bolnica.Repository

{
   public class AnamnesisRepository
   {
        private String FileLocation;
        public int next_id;
        public AnamnesisRepository(String fileLocation)
        {
            FileLocation = fileLocation;
        }
        public List<Model.Anamnesis> LoadAnamnesis()
      {
            List<Model.Anamnesis> anamneses = new List<Model.Anamnesis>();

            try
            {
                String line;
                StreamReader sr = new StreamReader(FileLocation);

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    string[] words = line.Split(',');


                    Model.Anamnesis an = new Model.Anamnesis(words[0], int.Parse(words[1]), words[2], words[3], words[4]);

                    anamneses.Add(an);

                    next_id = an.AnamnesisId;

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

            return anamneses;
        }
      
      public void SaveAnamnesis(List<Model.Anamnesis> anamnesisList)
      {
            File.Delete(FileLocation);
            String line;
            List<String> lines = new List<String>();

            foreach (Model.Anamnesis an in anamnesisList)
            {
                if (an.deleted == false)
                {
                    line = an.patient.User.Username + "," + an.AnamnesisId + "," + an.TypeAnamnesis + "," + an.DescriptionAnamnesis + "," + an.OpinionForAnamnesis;
                    lines.Add(line);
                }
            }
            File.WriteAllLines(FileLocation, lines);
        }
      
      public void DeleteAnamnesiss()
      {
            File.Delete(FileLocation);
      }
   

   
   }
}
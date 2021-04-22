using System;
using System.Collections.Generic;
using System.IO;

namespace Bolnica.Repository
{
   public class PrescriptionRepository
   {
        private String FileLocation;
        public int next_id;

        public PrescriptionRepository(String fileLocation)
        {
            FileLocation = fileLocation;
        }
        public List<Model.Prescription> LoadPrescription()
      {
            List<Model.Prescription> prescriptions = new List<Model.Prescription>();

            try
            {
                String line;
                StreamReader sr = new StreamReader(FileLocation);

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    string[] words = line.Split(',');


                    Model.Prescription pr = new Model.Prescription(int.Parse(words[0]), int.Parse(words[1]), Convert.ToDateTime(words[2]),
                        Convert.ToDateTime(words[3]), words[4], int.Parse(words[5]), words[6]);


                    prescriptions.Add(pr);

                    next_id = pr.PrescriptionId;

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

            return prescriptions;
        }
      
      public void SavePrescription(List<Model.Prescription> prescriptions)
      {
            File.Delete(FileLocation);
            String line;
            List<String> lines = new List<String>();

            foreach (Model.Prescription pr in prescriptions)
            {
                if (pr.deleted == false)
                {
                    line = pr.Anamnesis.AnamnesisId + "," + pr.PrescriptionId + "," + pr.StartDatePrescription.ToString() + "," +
                        pr.EndDatePrescription.ToString() + "," + pr.DescriptionPrescription + "," + pr.QuantityPrescription.ToString() + "," +
                        pr.drug.DrugName;
                }
            }
            File.WriteAllLines(FileLocation, lines);
        }




        public void DeletePrescriptions()
        {
            File.Delete(FileLocation);
        }
   
   
   }
}
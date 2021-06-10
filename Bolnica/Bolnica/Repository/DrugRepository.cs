using System;
using System.Collections.Generic;
using System.IO;

namespace Bolnica.Repository
{
    public class DrugRepository
    {
        private String FileLocation;
        private int next_id;

        public int getNextId()
        {
            next_id++;
            return next_id;
        }
        public DrugRepository(string fileLocation)
        {
            FileLocation = fileLocation;
        }
        public List<Model.Drug> LoadDrug()
        {
            List<Model.Drug> drugs = new List<Model.Drug>();
            try
            {
                String line;
                StreamReader sr = new StreamReader(FileLocation);

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    string[] words = line.Split(',');

                    Model.Drug drug = new Model.Drug(int.Parse(words[0]), words[1], words[2], int.Parse(words[3]),
                        double.Parse(words[4]), words[5], (Model.TypeOfApprovedDrug)Enum.Parse(typeof(Model.TypeOfApprovedDrug), words[6]), words[7], words[8]);

                    drugs.Add(drug);
                    next_id = drug.DrugId;

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

            return drugs;
        }

        

        public void SaveDrug(List<Model.Drug> drugList)
        {
            File.Delete(FileLocation);
            String line;
            List<String> lines = new List<String>();

            foreach (Model.Drug drug in drugList)
            {
                if (drug.DrugType != Model.TypeOfApprovedDrug.Deleted)
                {
                    line = drug.DrugId.ToString() + "," + drug.DrugName + "," + drug.DrugDescription + ","
                        + drug.DrugQuantity + "," + drug.DrugWeight.ToString() + "," + drug.DrugComponents + ","
                        + drug.DrugType.ToString() + "," + drug.AlternativeDrug+","+drug.DrugComment;
                    lines.Add(line);
                }

            }
            File.WriteAllLines(FileLocation, lines);
        }

        public void DeleteDrugs()
        {
            File.Delete(FileLocation);
        }



    }
}



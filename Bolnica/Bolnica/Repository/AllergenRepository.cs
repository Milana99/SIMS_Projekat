/***********************************************************************
 * Module:  DoctorRepository.cs
 * Author:  pc
 * Purpose: Definition of the Class Bolnica.Repository.DoctorRepository
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Bolnica.Model;
using System.IO;
namespace Bolnica.Repository
{
    public class AllergenRepository
    {
        private String FileLocation;
        private int nextId;
        public AllergenRepository(String fileLocation)
        {
            FileLocation = fileLocation;
            nextId = 0;
        }

        public List<Allergen> LoadAllergen()
        {
            List<Model.Allergen> allergens = new List<Allergen>();
            try
            {
                String line;
                StreamReader sr = new StreamReader(FileLocation);

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    string[] words = line.Split(',');


                    Model.Allergen allergen = new Model.Allergen(int.Parse(words[0]), words[1], words[2]);

                    allergens.Add(allergen);

                    nextId = allergen.getAllergenId();

                }
                nextId++;

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
            return allergens;
        }

        public void SaveAllergen(List<Allergen> allergenList)
        {
            File.Delete(FileLocation);
            String line;
            List<String> lines = new List<String>();

            foreach (Model.Allergen allergen in allergenList)
            {
                if (!allergen.isDeleted())
                {
                    line = allergen.getAllergenId().ToString() + "," + allergen.getDrug() + "," + allergen.getPatient();
                    lines.Add(line);
                }
            }
            File.WriteAllLines(FileLocation, lines);
        }

        public void DeleteAllergen()
        {
            File.Delete(FileLocation);
        }
        public int getNextId()
        {
            return nextId;
        }



    }
}
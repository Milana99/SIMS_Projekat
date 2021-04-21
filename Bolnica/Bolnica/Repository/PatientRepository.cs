using System;
using System.Collections.Generic;
using System.IO;

namespace Bolnica.Repository
{
   public class PatientRepository
   {
        private String FileLocation;

        public PatientRepository(String fileLocation)
        {
            FileLocation = fileLocation;
        }
        public List<Model.Patient> LoadPatient()
      {

            List<Model.Patient> patients = new List<Model.Patient>();

            try
            {
                String line;
                StreamReader sr = new StreamReader(FileLocation);

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    string[] words = line.Split(',');

                    
                    Model.Patient pa= new Model.Patient(words[0], words[1], words[2], words[3], 
                        Convert.ToDateTime(words[4]), (Model.Gender)Enum.Parse(typeof(Model.Gender), 
                        words[5]),long.Parse(words[6]), words[7], words[8], int.Parse(words[9]),
                        int.Parse(words[10]));

                    patients.Add(pa);

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

            return patients;
        }
      
      public void SavePatient(List<Model.Room> roomList)
      {
         // TODO: implement
      }
      
      public void DeletePatients()
      {
         // TODO: implement
      }
   
   
   }
}
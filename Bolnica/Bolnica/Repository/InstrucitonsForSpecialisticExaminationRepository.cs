
using System.Collections.Generic;
using System;
using Bolnica.Model;
using System.IO;

namespace Bolnica.Repository
{
    public class InstrucitonsForSpecialisticExaminationRepository
    {
        private String FileLocation;
        public int nextId;

        public InstrucitonsForSpecialisticExaminationRepository(string fileLocation)
        {
            FileLocation = fileLocation;
        }
        public List<InstructionsForSpecialistExamination> LoadSpecialisticExamination()
        {
            List<Model.InstructionsForSpecialistExamination> specialistExaminations = new List<Model.InstructionsForSpecialistExamination>();
            try
            {
                String line;
                StreamReader sr = new StreamReader(FileLocation);

                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(',');

                    Model.InstructionsForSpecialistExamination Examination = new Model.InstructionsForSpecialistExamination(int.Parse(words[0]),
                        words[1], words[2], words[3], words[4]);

                    specialistExaminations.Add(Examination);
                    nextId = Examination.SpecialistExaminationId;

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
            return specialistExaminations;
        }
        public int getNextId()
        {
            nextId++;
            return nextId;
        }

        public void SaveSpecialisticExamination(List<InstructionsForSpecialistExamination> SpecalistExaminations)
        {
            File.Delete(FileLocation);
            String line;
            List<String> lines = new List<String>();

            foreach (Model.InstructionsForSpecialistExamination SpecialistExamination in SpecalistExaminations)
            {

                line = SpecialistExamination.SpecialistExaminationId.ToString() + "," + 
                    SpecialistExamination.SpecialistDoctor.User.Username + "," + 
                    SpecialistExamination.ReferDoctor.User.Username + "," + 
                    SpecialistExamination.patient.User.Username + "," + 
                    SpecialistExamination.DescriptionSpecialistExamination;
                lines.Add(line);

            }
            File.WriteAllLines(FileLocation, lines);
        }

        public void DeleteSpecialisticExamination()
        {
            File.Delete(FileLocation);
        }



    }
}
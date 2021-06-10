/***********************************************************************
 * Module:  DoctorRepository.cs
 * Author:  pc
 * Purpose: Definition of the Class Bolnica.Repository.DoctorRepository
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
namespace Bolnica.Repository
{
    public class InstructionsForHospitalTreatmentRepository : IRepo<Model.InstructionsForHospitalTreatment>
    {

        private String FileLocation;
        private int nextId;

        public InstructionsForHospitalTreatmentRepository(String fileLocation)
        {
            FileLocation = fileLocation;
            nextId = 0;
        }
        public List<Model.InstructionsForHospitalTreatment> Load()
        {
            List<Model.InstructionsForHospitalTreatment> instructions = new List<Model.InstructionsForHospitalTreatment>();

            try
            {
                String line;
                StreamReader sr = new StreamReader(FileLocation);

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    string[] words = line.Split(',');


                    Model.InstructionsForHospitalTreatment instruction = new Model.InstructionsForHospitalTreatment(int.Parse(words[0]), 
                        words[1], int.Parse(words[2]), int.Parse(words[3]),DateTime.Parse(words[4]), DateTime.Parse(words[5]));

                    instructions.Add(instruction);

                    nextId = instruction.getId();

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

            return instructions;
        }

        public void Save(List<Model.InstructionsForHospitalTreatment> instructions)
        {
            File.Delete(FileLocation);
            String line;
            List<String> lines = new List<String>();

            foreach (Model.InstructionsForHospitalTreatment instruction in instructions)
            {
                if (!instruction.getDeleted())
                {
                    line = instruction.getId().ToString() + "," + instruction.getPatient() + "," + instruction.GetRoom().ToString() + "," + instruction.getBed().ToString() +","+
                    instruction.getStartDate().ToString() + "," + instruction.getEndDate().ToString();
                    lines.Add(line);
                }
            }
            File.WriteAllLines(FileLocation, lines);
        }

        public void Delete()
        {
            File.Delete(FileLocation);
        }
        public int getNextId()
        {
            return nextId;
        }



    }
}
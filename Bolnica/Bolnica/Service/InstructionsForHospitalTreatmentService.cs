/***********************************************************************
 * Module:  InstructionsForHospitalTreatmentController.cs
 * Author:  pc
 * Purpose: Definition of the Class Bolnica.Controller.InstructionsForHospitalTreatmentController
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace Bolnica.Service
{

    public class InstructionsForHospitalTreatmentService
    {
        private Repository.IRepo<Model.InstructionsForHospitalTreatment> instructionsRepository;
        
        public InstructionsForHospitalTreatmentService(Repository.IRepo<Model.InstructionsForHospitalTreatment> repo)
        {
            instructionsRepository = repo;
        }
        public void CreateInstructionsForHospitalTreatment(Model.InstructionsForHospitalTreatment instruction)
        {
            List<Model.InstructionsForHospitalTreatment> instructions = GetAllInstructionsForHospitalTreatment();
            instructions.Add(instruction);
            instructionsRepository.Save(instructions);
        }

        public void UpdateInstructionsForHospitalTreatment(Model.InstructionsForHospitalTreatment updatedInstruction)
        {
            List<Model.InstructionsForHospitalTreatment> instructions = GetAllInstructionsForHospitalTreatment();
            foreach(Model.InstructionsForHospitalTreatment instruction in instructions)
            {
                if(instruction.getId() == updatedInstruction.getId())
                {
                    instruction.setEndDate(updatedInstruction.getEndDate());
                    instructionsRepository.Save(instructions);
                    return;
                }
            }
        }

        public void DeleteInstructionsForHospitalTreatment(int instructionsForHospitalTreatmentId)
        {
            List<Model.InstructionsForHospitalTreatment> instructions = GetAllInstructionsForHospitalTreatment();
            foreach(Model.InstructionsForHospitalTreatment instruction in instructions)
            {
                if(instruction.getId() == instructionsForHospitalTreatmentId)
                {
                    instruction.deleteInstruction();
                    instructionsRepository.Save(instructions);
                    return;
                }
            }

        }

        public List<Model.InstructionsForHospitalTreatment> GetAllInstructionsForHospitalTreatment()
        {
            List<Model.InstructionsForHospitalTreatment> instructions = instructionsRepository.Load();
            return instructions;
        }

        public Model.InstructionsForHospitalTreatment GetOneInstructionsForHospitalTreatment(int instructionsForHospitalTreatmentId)
        {
            List<Model.InstructionsForHospitalTreatment> instructions = GetAllInstructionsForHospitalTreatment();
            foreach(Model.InstructionsForHospitalTreatment instruction in instructions)
            {
                if(instruction.getId() == instructionsForHospitalTreatmentId)
                {
                    return instruction;
                }
            }
            return null;
        }
        public int getNextId()
        {
            return instructionsRepository.getNextId();
        }
    }
}
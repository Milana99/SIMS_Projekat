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
        private Repository.InstructionsForHospitalTreatmentRepository instructionsRepository;
        
        public InstructionsForHospitalTreatmentService()
        {
            instructionsRepository = new Repository.InstructionsForHospitalTreatmentRepository(@"C:\Users\pc\OneDrive\Radna površina\Radovan\Upravnik\Instructions.txt");
        }
        public void CreateInstructionsForHospitalTreatment(Model.InstructionsForHospitalTreatment instruction)
        {
            List<Model.InstructionsForHospitalTreatment> instructions = GetAllInstructionsForHospitalTreatment();
            instructions.Add(instruction);
            instructionsRepository.SaveInstructonForHospitalTreatment(instructions);
        }

        public void UpdateInstructionsForHospitalTreatment(Model.InstructionsForHospitalTreatment updatedInstruction)
        {
            List<Model.InstructionsForHospitalTreatment> instructions = GetAllInstructionsForHospitalTreatment();
            foreach(Model.InstructionsForHospitalTreatment instruction in instructions)
            {
                if(instruction.getId() == updatedInstruction.getId())
                {
                    instruction.UpdateEndDate(updatedInstruction.getEndDate());
                    instructionsRepository.SaveInstructonForHospitalTreatment(instructions);
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
                    instructionsRepository.SaveInstructonForHospitalTreatment(instructions);
                    return;
                }
            }

        }

        public List<Model.InstructionsForHospitalTreatment> GetAllInstructionsForHospitalTreatment()
        {
            List<Model.InstructionsForHospitalTreatment> instructions = instructionsRepository.LoadInstructonForHospitalTreatment();
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
/***********************************************************************
 * Module:  InstructionsForHospitalTreatmentController.cs
 * Author:  pc
 * Purpose: Definition of the Class Bolnica.Controller.InstructionsForHospitalTreatmentController
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace Bolnica.Controller
{

    public class InstructionsForHospitalTreatmentController
    {
        private Service.InstructionsForHospitalTreatmentService instructionsService;
        public InstructionsForHospitalTreatmentController()
        {
            instructionsService = new Service.InstructionsForHospitalTreatmentService();
        }
        public void CreateInstructionsForHospitalTreatment(Model.InstructionsForHospitalTreatment instructionsForHospitalTreatment)
        {
            instructionsService.CreateInstructionsForHospitalTreatment(instructionsForHospitalTreatment);
        }

        public void UpdateInstructionsForHospitalTreatment(Model.InstructionsForHospitalTreatment instructionsForHospitalTreatment)
        {
            instructionsService.UpdateInstructionsForHospitalTreatment(instructionsForHospitalTreatment);
        }
        public int getNextId()
        {
            return instructionsService.getNextId();
        }

        public void DeleteInstructionsForHospitalTreatment(int instructionsForHospitalTreatmentId)
        {
            instructionsService.DeleteInstructionsForHospitalTreatment(instructionsForHospitalTreatmentId);
        }

        public List<Model.InstructionsForHospitalTreatment> GetAllInstructionsForHospitalTreatment()
        {
            return instructionsService.GetAllInstructionsForHospitalTreatment();
        }

        public Model.InstructionsForHospitalTreatment GetOneInstructionsForHospitalTreatment(int instructionsForHospitalTreatmentId)
        {
            return instructionsService.GetOneInstructionsForHospitalTreatment(instructionsForHospitalTreatmentId);
        }

    }
}
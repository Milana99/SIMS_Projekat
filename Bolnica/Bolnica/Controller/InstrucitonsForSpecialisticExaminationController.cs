using System.Collections.Generic;
using System;
using Bolnica.Model;
namespace Bolnica.Controller
{
    public class InstrucitonsForSpecialisticExaminationController
    {
        public Bolnica.Service.InstrucitonsForSpecialisticExaminationService specialisticExaminationService;

        public InstrucitonsForSpecialisticExaminationController()
        {
            specialisticExaminationService = new Service.InstrucitonsForSpecialisticExaminationService();
        }
        public InstrucitonsForSpecialisticExaminationController GetOneSpecialisticExamination(int specialisticExaminationId)
        {
            // TODO: implement
            return null;
        }

        public List<Model.InstructionsForSpecialistExamination> GetAllSpecialisticExamination()
        {
            List<Model.InstructionsForSpecialistExamination> instructions =  specialisticExaminationService.GetAllSpecialisticExamination();
            return instructions;
        }

        public void CreateSpecialisticExamination(Model.InstructionsForSpecialistExamination specialisticExamination)
        {
            specialisticExaminationService.CreateSpecialisticExamination(specialisticExamination);
        }



    }
}
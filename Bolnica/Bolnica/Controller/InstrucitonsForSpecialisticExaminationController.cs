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

        public List<InstrucitonsForSpecialistExamination> GetAllSpecialisticExamination()
        {
            return specialisticExaminationService.GetAllSpecialisticExamination();
        }

        public void CreateSpecialisticExamination(Model.InstrucitonsForSpecialistExamination specialisticExamination)
        {
            specialisticExaminationService.CreateSpecialisticExamination(specialisticExamination);
        }



    }
}
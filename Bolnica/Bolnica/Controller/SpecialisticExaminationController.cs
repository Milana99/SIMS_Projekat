using System.Collections.Generic;
using System;
using Bolnica.Model;
namespace Bolnica.Controller
{
    public class SpecialisticExaminationController
    {
        public Bolnica.Service.SpecialisticExaminationService specialisticExaminationService;

        public SpecialisticExaminationController()
        {
            specialisticExaminationService = new Service.SpecialisticExaminationService();
        }
        public SpecialisticExaminationController GetOneSpecialisticExamination(int specialisticExaminationId)
        {
            // TODO: implement
            return null;
        }

        public List<SpecialistExamination> GetAllSpecialisticExamination()
        {
            return specialisticExaminationService.GetAllSpecialisticExamination();
        }

        public void CreateSpecialisticExamination(Model.SpecialistExamination specialisticExamination)
        {
            specialisticExaminationService.CreateSpecialisticExamination(specialisticExamination);
        }



    }
}
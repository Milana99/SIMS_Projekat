using System.Collections.Generic;
using System;
using Bolnica.Model;

namespace Bolnica.Service
{
    public class SpecialisticExaminationService
    {
        public Repository.SpecialisticExaminationRepository specialisticExaminationRepository;

        public SpecialisticExaminationService()
        {
            specialisticExaminationRepository = new Repository.SpecialisticExaminationRepository(@"C:\Users\pc\OneDrive\Radna površina\Radovan\Upravnik\Specialistic.txt");
        }

        public SpecialisticExaminationService GetOneSpecialisticExamination(int specialisticExaminationId)
        {
            
            return null;
        }

        public List<SpecialistExamination> GetAllSpecialisticExamination()
        {
            return specialisticExaminationRepository.LoadSpecialisticExamination();
        }

        public void CreateSpecialisticExamination(Model.SpecialistExamination specialisticExamination)
        {
            List<SpecialistExamination> specialistExaminations = GetAllSpecialisticExamination();
            specialistExaminations.Add(specialisticExamination);
            specialisticExaminationRepository.SaveSpecialisticExamination(specialistExaminations);

        }

        

    }
}
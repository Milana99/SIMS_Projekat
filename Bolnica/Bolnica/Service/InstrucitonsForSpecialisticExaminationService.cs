using System.Collections.Generic;
using System;
using Bolnica.Model;

namespace Bolnica.Service
{
    public class InstrucitonsForSpecialisticExaminationService
    {
        public Repository.InstrucitonsForSpecialisticExaminationRepository specialisticExaminationRepository;

        public InstrucitonsForSpecialisticExaminationService()
        {
            specialisticExaminationRepository = new Repository.InstrucitonsForSpecialisticExaminationRepository(@"C:\Users\pc\OneDrive\Radna površina\Radovan\Upravnik\Specialistic.txt");
        }

        public InstrucitonsForSpecialisticExaminationService GetOneSpecialisticExamination(int specialisticExaminationId)
        {
            
            return null;
        }

        public List<InstructionsForSpecialistExamination> GetAllSpecialisticExamination()
        {
            return specialisticExaminationRepository.LoadSpecialisticExamination();
        }

        public void CreateSpecialisticExamination(Model.InstructionsForSpecialistExamination specialisticExamination)
        {
            List<InstructionsForSpecialistExamination> specialistExaminations = GetAllSpecialisticExamination();
            specialistExaminations.Add(specialisticExamination);
            specialisticExaminationRepository.SaveSpecialisticExamination(specialistExaminations);

        }

        

    }
}
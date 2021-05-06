/***********************************************************************
 * Module:  SpecialistExamination.cs
 * Author:  pc
 * Purpose: Definition of the Class Bolnica.Model.SpecialistExamination
 ***********************************************************************/

using System;

namespace Bolnica.Model
{
    public class SpecialistExamination
    {
        public Doctor SpecialistDoctor;
        public Doctor ReferDoctor;
        public Patient patient;
        public int SpecialistExaminationId;
        public String DescriptionSpecialistExamination;

        public SpecialistExamination(int id, string Specialist, string refer, string patient,  string description)
        {
            SpecialistExaminationId = id;
            SpecialistDoctor = new Doctor(Specialist);
            ReferDoctor = new Doctor(refer);
            this.patient = new Patient(patient);
            DescriptionSpecialistExamination = description;
        }


    }
}
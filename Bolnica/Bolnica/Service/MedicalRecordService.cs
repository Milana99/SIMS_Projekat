using System;
using System.Collections.Generic;

namespace Bolnica.Service
{
   public class MedicalRecordService
   {
        public Bolnica.Repository.MedicalRecordRepository medicalRecordRepository;
        public List<Model.MedicalRecord> GetAllMedicalRecord()
      {
         // TODO: implement
         return null;
      }
      
      public Model.MedicalRecord GetOneMedicalRecord(String patientUsername)
      {
         // TODO: implement
         return null;
      }
      
      public void CreateMedicalRecord(Model.Patient patient)
      {
         // TODO: implement
      }
      
      public void UpdateMedicalRecord(Model.Patient patient, Model.Anamnesis anamnesis)
      {
         // TODO: implement
      }
      
      public void DeleteMedicalRecord(int patientUsername)
      {
         // TODO: implement
      }
      
      public Model.MedicalRecord GetMedicalRecordByPatient(String petientUsername)
      {
         // TODO: implement
         return null;
      }
      
      public Model.MedicalRecord GetMedicalRecordByDoctor(String patientUsername, String doctorUsername)
      {
         // TODO: implement
         return null;
      }
      
      public Bolnica.Model.MedicalRecord GetMedicalRecordBySecretary(String patientsUsername)
      {
         // TODO: implement
         return null;
      }
   

   
   }
}
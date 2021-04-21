using System.Collections.Generic;

using System;

namespace Bolnica.Controller
{
   public class MedicalRecordController
   {
        public Bolnica.Service.MedicalRecordService medicalRecordService;
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
      
      public Bolnica.Model.MedicalRecord GetMedicalRecordBySecretary(String patientUsername)
      {
         // TODO: implement
         return null;
      }
   
      
   
   }
}
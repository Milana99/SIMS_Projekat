using System;
using System.Collections.Generic;

namespace Bolnica.Controller
{
   public class PrescriptionController
   {
        public Bolnica.Service.PrescriptionService prescriptionService;
        public List<Model.Prescription> GetAllPrescriptions()
      {
         // TODO: implement
         return null;
      }
      
      public Bolnica.Model.Prescription GetOnePrescription(int perceptionId)
      {
         // TODO: implement
         return null;
      }
      
      public List<Model.Prescription> GetAllPrescriptionAnamnesis(int anamnesisId)
      {
         // TODO: implement
         return null;
      }
      
      public void CreatePrescription(int perceptionId, DateTime startDate, DateTime endDate, String description, int quantity, Model.Drug drug)
      {
         // TODO: implement
      }
      
      public void UpdatePrescription(int perceptionId, int startDate, int endDate, int description, int quantity)
      {
         // TODO: implement
      }
      
      public void DeletePrescription(int perceptionId)
      {
         // TODO: implement
      }
   
      
   
   }
}
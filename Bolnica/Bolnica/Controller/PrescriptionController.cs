using System;
using System.Collections.Generic;

namespace Bolnica.Controller
{
   public class PrescriptionController
   {
        public Bolnica.Service.PrescriptionService prescriptionService;

        public PrescriptionController()
        {
            prescriptionService = new Service.PrescriptionService();
        }
        public List<Model.Prescription> GetAllPrescriptions()
      {
            return prescriptionService.GetAllPrescriptions();
      }
      
      public Bolnica.Model.Prescription GetOnePrescription(int perceptionId)
      {
            return prescriptionService.GetOnePrescription(perceptionId);
      }
      
      public List<Model.Prescription> GetAllPrescriptionAnamnesis(int anamnesisId)
      {
            return prescriptionService.GetAllPrescriptionAnamnesis(anamnesisId);
      }
      
      public void CreatePrescription(int AnamId, int PresId, DateTime Start, DateTime End, String Description, int Quantity, String dr)
      {
            prescriptionService.CreatePrescription(AnamId, PresId, Start, End, Description, Quantity, dr);
      }
      
      public void UpdatePrescription(int PresId, String Description, int Quantity)
      {
            prescriptionService.UpdatePrescription(PresId, Description, Quantity);
      }

        public void DeletePrescription(int perceptionId)
        {
            prescriptionService.DeletePrescription(perceptionId);
        }
   
      
   
   }
}
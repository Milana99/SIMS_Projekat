using System;
using System.Collections.Generic;
namespace Bolnica.Service
{
   public class PrescriptionService
   {
        public Bolnica.Repository.PrescriptionRepository prescriptionRepository;

        public PrescriptionService()
        {
            prescriptionRepository = new Repository.PrescriptionRepository(@"C:\Users\pc\OneDrive\Radna površina\Radovan\Upravnik\Prescriptions.txt");
        }
        public List<Model.Prescription> GetAllPrescriptions()
      {
            return prescriptionRepository.LoadPrescription();
      }
      
      public Bolnica.Model.Prescription GetOnePrescription(int perceptionId)
      {
            List<Model.Prescription> prescriptions = GetAllPrescriptions();
            foreach(Model.Prescription pr in prescriptions)
            {
                if(pr.PrescriptionId == perceptionId)
                {
                    return pr;
                }
            }
            return null;
      }
      
      public List<Model.Prescription> GetAllPrescriptionAnamnesis(int anamnesisId)
      {
            List<Model.Prescription> prescriptions = GetAllPrescriptions();
            List<Model.Prescription> prescAnam = new List<Model.Prescription>();
            foreach(Model.Prescription pr in prescriptions)
            {
                if (pr.Anamnesis.AnamnesisId == anamnesisId)
                {
                    prescAnam.Add(pr);
                }
            }
            return prescAnam;
      }

        public void CreatePrescription(int AnamId, int PresId, DateTime Start, DateTime End, String Description, int Quantity, String dr)
        {
            List<Model.Prescription> prescriptions = GetAllPrescriptions();
            Model.Prescription pr = new Model.Prescription(AnamId, PresId, Start, End, Description, Quantity, dr);
            prescriptions.Add(pr);
            prescriptionRepository.SavePrescription(prescriptions);
        }
      
      public void UpdatePrescription(int PresId, String Description, int Quantity)
      {
            List<Model.Prescription> prescriptions = GetAllPrescriptions();
            foreach(Model.Prescription pr in prescriptions)
            {
                if (pr.PrescriptionId == PresId)
                {
                    pr.DescriptionPrescription = Description;
                    pr.QuantityPrescription = Quantity;
                    prescriptionRepository.SavePrescription(prescriptions);
                    return;
                }
            }
        }

        public void DeletePrescription(int perceptionId)
        {
            List<Model.Prescription> prescriptions = GetAllPrescriptions();
            foreach (Model.Prescription pr in prescriptions)
            {
                if (pr.PrescriptionId == perceptionId)
                {
                    pr.deleted = true;
                    prescriptionRepository.SavePrescription(prescriptions);
                    return;
                }
            }
        }
      
      public void SendNotificationToPatient(Bolnica.Model.Prescription prescription, Bolnica.Model.Drug drug, DateTime time)
      {
         // TODO: implement
      }
   
     
   
   }
}
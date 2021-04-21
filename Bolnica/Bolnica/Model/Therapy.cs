using System;

namespace Bolnica.Model
{
   public class Therapy
   {
      public System.Collections.ArrayList prescription;
        public Anamnesis anamnesis { get; set; }

        public int TherapyId { get; set; }
        public String Description { get; set; }

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetPrescription()
      {
         if (prescription == null)
            prescription = new System.Collections.ArrayList();
         return prescription;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetPrescription(System.Collections.ArrayList newPrescription)
      {
         RemoveAllPrescription();
         foreach (Prescription oPrescription in newPrescription)
            AddPrescription(oPrescription);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddPrescription(Prescription newPrescription)
      {
         if (newPrescription == null)
            return;
         if (this.prescription == null)
            this.prescription = new System.Collections.ArrayList();
         if (!this.prescription.Contains(newPrescription))
         {
            this.prescription.Add(newPrescription);
            newPrescription.SetTherapy(this);      
         }
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemovePrescription(Prescription oldPrescription)
      {
         if (oldPrescription == null)
            return;
         if (this.prescription != null)
            if (this.prescription.Contains(oldPrescription))
            {
               this.prescription.Remove(oldPrescription);
               oldPrescription.SetTherapy((Therapy)null);
            }
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllPrescription()
      {
         if (prescription != null)
         {
            System.Collections.ArrayList tmpPrescription = new System.Collections.ArrayList();
            foreach (Prescription oldPrescription in prescription)
               tmpPrescription.Add(oldPrescription);
            prescription.Clear();
            foreach (Prescription oldPrescription in tmpPrescription)
               oldPrescription.SetTherapy((Therapy)null);
            tmpPrescription.Clear();
         }
      }
      
   
   }
}
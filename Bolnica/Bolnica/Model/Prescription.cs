using System;

namespace Bolnica.Model
{
   public class Prescription
   {
        public Anamnesis Anamnesis { get; set; }
        public int PrescriptionId { get; set; }
        public DateTime StartDatePrescription { get; set; }
        public DateTime EndDatePrescription { get; set; }
        public String DescriptionPrescription { get; set; }
        public int QuantityPrescription { get; set; }
        public Drug drug { get; set; }
        public bool deleted;

        public System.Collections.ArrayList notification;

        public Prescription(int AnamId, int PresId, DateTime Start, DateTime End, String Description, int Quantity, String dr)
        {
            Anamnesis = new Anamnesis(AnamId);
            PrescriptionId = PresId;
            StartDatePrescription = Start;
            EndDatePrescription = End;
            DescriptionPrescription = Description;
            QuantityPrescription = Quantity;
            drug = new Drug(dr);
            deleted = false;
        }
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetNotification()
      {
         if (notification == null)
            notification = new System.Collections.ArrayList();
         return notification;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetNotification(System.Collections.ArrayList newNotification)
      {
         RemoveAllNotification();
         foreach (Notification oNotification in newNotification)
            AddNotification(oNotification);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddNotification(Notification newNotification)
      {
         if (newNotification == null)
            return;
         if (this.notification == null)
            this.notification = new System.Collections.ArrayList();
         if (!this.notification.Contains(newNotification))
            this.notification.Add(newNotification);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveNotification(Notification oldNotification)
      {
         if (oldNotification == null)
            return;
         if (this.notification != null)
            if (this.notification.Contains(oldNotification))
               this.notification.Remove(oldNotification);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllNotification()
      {
         if (notification != null)
            notification.Clear();
      }
      
      
      /// <pdGenerated>default parent getter</pdGenerated>
      
      
      /// <pdGenerated>default parent setter</pdGenerated>
      /// <param>newTherapy</param>
      
   
  
   
   }
}
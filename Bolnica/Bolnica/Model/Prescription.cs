using System;
using System.Collections.Generic;

namespace Bolnica.Model
{
   public class Prescription
   {
        public int PrescriptionId { get; set; }
        public DateTime StartDatePrescription { get; set; }
        public DateTime EndDatePrescription { get; set; }
        public String DescriptionPrescription { get; set; }
        public int QuantityPrescription { get; set; }
        public Drug drug { get; set; }
        public System.Collections.ArrayList notification;
      
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
      public Therapy therapy;
      
      /// <pdGenerated>default parent getter</pdGenerated>
      public Therapy GetTherapy()
      {
         return therapy;
      }
      
      /// <pdGenerated>default parent setter</pdGenerated>
      /// <param>newTherapy</param>
      public void SetTherapy(Therapy newTherapy)
      {
         if (this.therapy != newTherapy)
         {
            if (this.therapy != null)
            {
               Therapy oldTherapy = this.therapy;
               this.therapy = null;
               oldTherapy.RemovePrescription(this);
            }
            if (newTherapy != null)
            {
               this.therapy = newTherapy;
               this.therapy.AddPrescription(this);
            }
         }
      }

        public void GetPrescription(List<Prescription> listPrescription)
        {
            foreach(Prescription p in listPrescription)
            {
                int pr = DateTime.Compare(p.StartDatePrescription.AddHours(-3), DateTime.UtcNow);

                if(pr>0)
                {
                    if((p.StartDatePrescription.Month == DateTime.UtcNow.Month) && (p.StartDatePrescription.Day == DateTime.UtcNow.Day) && (p.StartDatePrescription.Hour == DateTime.UtcNow.Hour))
                    {
                       

                    }

                }
            }

        }


   
  
   
   }
}
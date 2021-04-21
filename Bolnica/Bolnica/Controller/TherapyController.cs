using System;
using System.Collections.Generic;

namespace Bolnica.Controller
{
   public class TherapyController
   {
        public Bolnica.Service.TherapyService therapyService;
        public List<Model.Therapy> GetAllTherapy()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Therapy GetOneTherapy(int therapyId)
      {
         // TODO: implement
         return null;
      }
      
      public void CreateTherapy(int therapyId, List<Model.Prescription> listPerceptions, String description)
      {
         // TODO: implement
      }
      
      public void UpdateTherapy(int therapyId, List<Model.Prescription> listPerceptions, String description)
      {
         // TODO: implement
      }
      
      public void DeleteTherapy(int therapyId)
      {
         // TODO: implement
      }
      
      public List<Model.Therapy> GetAllTherapyPatient(String patientUsername)
      {
         // TODO: implement
         return null;
      }
   
      
   
   }
}
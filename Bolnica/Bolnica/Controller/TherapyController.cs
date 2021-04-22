using System;
using System.Collections.Generic;

namespace Bolnica.Controller
{
   public class TherapyController
   {
        public Bolnica.Service.TherapyService therapyService;


        public TherapyController()
        {
            therapyService = new Service.TherapyService();
        }
        public List<Model.Therapy> GetAllTherapy()
      {
            return therapyService.GetAllTherapy();
      }
      
      public Model.Therapy GetOneTherapy(int therapyId)
      {
            return therapyService.GetOneTherapy(therapyId);
      }
      
      public void CreateTherapy(int anamnesisId, int therapyId, String Description)
      {
            therapyService.CreateTherapy(anamnesisId, therapyId, Description);
      }
      
      public void UpdateTherapy(int therapyId, String Description)
      {
            therapyService.UpdateTherapy(therapyId, Description);
      }
      
      public void DeleteTherapy(int therapyId)
      {
            therapyService.DeleteTherapy(therapyId);
      }
      
      public List<Model.Therapy> GetAllTherapyAnamnesis(int anamnesisId)
      {
            return therapyService.GetAllTherapyAnamnesis(anamnesisId);
      }
   
      
   
   }
}
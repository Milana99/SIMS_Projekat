using System.Collections.Generic;
using System;

namespace Bolnica.Controller
{
   public class AnamnesisController
   {
        public Bolnica.Service.AnamnesisService anamnesisService;

        public AnamnesisController()
        {
            anamnesisService = new Service.AnamnesisService();
        }
        public List<Model.Anamnesis> GetAllAnamnesis()
      {
            return anamnesisService.GetAllAnamnesis();
      }
      
      public Model.Anamnesis GetOneAnamnesis(int anamnesisId)
      {
            return anamnesisService.GetOneAnamnesis(anamnesisId);
      }
      
      public List<Model.Anamnesis> GetAllAnamnesisPatient(String patientUsername)
      {
            return anamnesisService.GetAllAnamnesisPatient(patientUsername);
      }
      
      public void CreateAnamnesis(String patientUserName, int AnamnesisId, String Type, String Description, String Opinion)
      {
            anamnesisService.CreateAnamnesis(patientUserName, AnamnesisId, Type, Description, Opinion);
      }
      
      public void UpdateAnamnesis(int anamnesisId, String type,  String description, String opinion)
      {
            anamnesisService.UpdateAnamnesis(anamnesisId, type, description, opinion);
      }
      
      public void DeleteAnamnesis(int anamnesisId)
      {
            anamnesisService.DeleteAnamnesis(anamnesisId);
      }
   
      
   
   }
}
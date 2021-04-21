using System.Collections.Generic;
using System;

namespace Bolnica.Controller
{
   public class AnamnesisController
   {
        public Bolnica.Service.AnamnesisService anamnesisService;
        public List<Model.Anamnesis> GetAllAnamnesis()
      {
         // TODO: implement
         return null;
      }
      
      public AnamnesisController GetOneAnamnesis(int anamnesisId)
      {
         // TODO: implement
         return null;
      }
      
      public List<Model.Anamnesis> GetAllAnamnesisPatient(String patientUsername)
      {
         // TODO: implement
         return null;
      }
      
      public void CreateAnamnesis(int anamnesisId, string type, string name, string description, string opinion, int patientUsername, Model.Therapy therapy)
      {
         // TODO: implement
      }
      
      public void UpdateAnamnesis(int anamnesisId, String type, String name, String description, String opinion, Model.Therapy therapy)
      {
         // TODO: implement
      }
      
      public void DeleteAnamnesis(int anamnesisId)
      {
         // TODO: implement
      }
   
      
   
   }
}
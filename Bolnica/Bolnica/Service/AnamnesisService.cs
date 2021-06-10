using System;
using System.Collections.Generic;

namespace Bolnica.Service
{
   public class AnamnesisService
   {
        public Bolnica.Repository.AnamnesisRepository anamnesisRepository;

        public AnamnesisService()
        {
            anamnesisRepository = new Repository.AnamnesisRepository(@"C:\Users\pc\OneDrive\Radna površina\Radovan\Upravnik\Anamnesis.txt");
        }

      public List<Model.Anamnesis> GetAllAnamnesis()
      {

            return anamnesisRepository.Load();
      }
      
      public Model.Anamnesis GetOneAnamnesis(int anamnesisId)
      {
         // TODO: implement
         return null;
      }
      
      public List<Model.Anamnesis> GetAllAnamnesisPatient(String patientUsername)
      {
            List<Model.Anamnesis> anamneses = GetAllAnamnesis();
            List<Model.Anamnesis> patientAnam = new List<Model.Anamnesis>();

            foreach(Model.Anamnesis an in anamneses)
            {
                if (an.patient.User.Username == patientUsername)
                {
                    patientAnam.Add(an);
                }
            }
            return patientAnam;
      }
      
      public void CreateAnamnesis(String patientUserName, int AnamnesisId, String Type, String Description, String Opinion)
      {
            List<Model.Anamnesis> anamneses = GetAllAnamnesis();
            Model.Anamnesis an = new Model.Anamnesis(patientUserName, AnamnesisId, Type, Description, Opinion);
            anamneses.Add(an);
            anamnesisRepository.Save(anamneses);
      }
      
      public void UpdateAnamnesis(int anamnesisId, String Type, String Description, String Opinion)
      {
            List<Model.Anamnesis> anamneses = GetAllAnamnesis();
            foreach(Model.Anamnesis an in anamneses)
            {
                if(an.AnamnesisId == anamnesisId)
                {
                    an.TypeAnamnesis = Type;
                    an.DescriptionAnamnesis = Description;
                    an.OpinionForAnamnesis = Opinion;
                    anamnesisRepository.Save(anamneses);
                    return;
                }
            }
      }
      
      public void DeleteAnamnesis(int anamnesisId)
      {
            List<Model.Anamnesis> anamneses = GetAllAnamnesis();
            foreach (Model.Anamnesis an in anamneses)
            {
                if(an.AnamnesisId == anamnesisId)
                {
                    an.deleted = true;
                    anamnesisRepository.Save(anamneses);
                    return;
                }
            }
        }
   
      
   
   }
}
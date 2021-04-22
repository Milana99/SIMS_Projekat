using System.Collections.Generic;
using System;

namespace Bolnica.Service
{
   public class TherapyService
   {
        public Bolnica.Repository.TherapyRepository therapyRepository;

        public TherapyService()
        {
            therapyRepository = new Repository.TherapyRepository(@"C:\Users\pc\OneDrive\Radna površina\Radovan\Upravnik\Anamnesis.txt");
        }
        public List<Model.Therapy> GetAllTherapy()
      {
            return therapyRepository.LoadTherapy();
      }
      
      public Model.Therapy GetOneTherapy(int therapyId)
      {
         // TODO: implement
         return null;
      }

        public void CreateTherapy(int AnamnesisId, int TherapyId, String Description)
        {
            List<Model.Therapy> therapies = GetAllTherapy();
            Model.Therapy th = new Model.Therapy(AnamnesisId, TherapyId, Description);
            therapies.Add(th);
            therapyRepository.SaveTherapy(therapies);

        }
        public void UpdateTherapy(int therapyId, String description)
        {
            List<Model.Therapy> therapies = GetAllTherapy();
            foreach (Model.Therapy th in therapies)
            {
                if(th.TherapyId == therapyId)
                {
                    th.Description = description;
                    therapyRepository.SaveTherapy(therapies);
                    return;
                }
            }
        }
      
      public void DeleteTherapy(int therapyId)
      {
            List<Model.Therapy> therapies = GetAllTherapy();
            foreach (Model.Therapy th in therapies)
            {
                if (th.TherapyId == therapyId)
                {
                    th.deleted = true;
                    therapyRepository.SaveTherapy(therapies);
                    return;
                }
            }
        }
      
      public List<Model.Therapy> GetAllTherapyAnamnesis(int anamnesisId)
      {
            List<Model.Therapy> therapies = GetAllTherapy();
            List<Model.Therapy> anamTherapies = new List<Model.Therapy>();
            foreach (Model.Therapy th in therapies)
            {
                if (th.anamnesis.AnamnesisId == anamnesisId)
                {
                    anamTherapies.Add(th);
                }
            }
            return null;
        }
   

   
   }
}
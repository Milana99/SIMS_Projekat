using System.Collections.Generic;
using System;

namespace Bolnica.Service
{
    public class TherapyService
    {
        public Bolnica.Repository.IRepo<Model.Therapy> therapyRepository;

        public TherapyService(Repository.IRepo<Model.Therapy> repo)
        {
            therapyRepository = repo;
        }
        public List<Model.Therapy> GetAllTherapy()
        {
            return therapyRepository.Load();
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
            therapyRepository.Save(therapies);

        }
        public void UpdateTherapy(int therapyId, String description)
        {
            List<Model.Therapy> therapies = GetAllTherapy();
            foreach (Model.Therapy th in therapies)
            {
                if (th.TherapyId == therapyId)
                {
                    th.Description = description;
                    therapyRepository.Save(therapies);
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
                    therapyRepository.Save(therapies);
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
        int getNextId()
        {
            return therapyRepository.getNextId();
        }


    }
}
/***********************************************************************
 * Module:  RenovationService.cs
 * Author:  pc
 * Purpose: Definition of the Class Bolnica.Service.RenovationService
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Bolnica.Model;

namespace Bolnica.Service
{
    public class AllergenService
    {
        private Repository.AllergenRepository allergenRepository;

        public AllergenService()
        {
            allergenRepository = new Repository.AllergenRepository(@"C:\Users\pc\OneDrive\Radna površina\Radovan\Upravnik\Allergen.txt");
        }
        public Allergen GetOneAllergen(int allergenId)
        {
            List<Allergen> allergens = GetAllAllergen();
            foreach (Allergen allergen in allergens)
            {
                if (allergen.getAllergenId() == allergenId)
                {
                    return allergen;
                }
            }
            return null;
        }

        public List<Allergen> GetAllAllergen()
        {
            return allergenRepository.LoadAllergen();
        }

        public void CreateAllergen(Allergen allergen)
        {
            List<Allergen> allergens = GetAllAllergen();
            allergens.Add(allergen);
            allergenRepository.SaveAllergen(allergens);
        }

        public void DeleteAllergen(int allergenId)
        {
            List<Allergen> allergens = GetAllAllergen();
            foreach (Allergen allergen in allergens)
            {
                if (allergen.getAllergenId() == allergenId)
                {
                    allergen.delete();
                    allergenRepository.SaveAllergen(allergens);
                    return;
                }
            }
        }

        public void UpdateAllergen(Allergen UpdatedAllergen)
        {
            List<Allergen> allergens = GetAllAllergen();
            foreach (Allergen allergen in allergens)
            {
                if (allergen.getAllergenId() == UpdatedAllergen.getAllergenId())
                {
                    allergen.UpdateAllergen(UpdatedAllergen);
                    return;
                }
            }
        }
        public List<Allergen> GetAllergensForPatient(String PatientUserName)
        {
            List<Allergen> allergens = GetAllAllergen();
            List<Allergen> PatientAllergens = new List<Allergen>();
            foreach(Allergen allergen in allergens)
            {
                if(allergen.getPatient() == PatientUserName)
                {
                    PatientAllergens.Add(allergen);
                }
            }
            return PatientAllergens;
        }

        public int getNextId()
        {
            return allergenRepository.getNextId();
        }



    }
}
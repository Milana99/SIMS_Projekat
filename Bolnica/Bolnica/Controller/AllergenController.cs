/***********************************************************************
 * Module:  RenovationService.cs
 * Author:  pc
 * Purpose: Definition of the Class Bolnica.Service.RenovationService
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Bolnica.Model;

namespace Bolnica.Controller
{
    public class AllergenController
    {
        private Service.AllergenService allergenService;
        public AllergenController()
        {
            allergenService = new Service.AllergenService();
        }
        public Allergen GetOneAllergen(int allergenId)
        {
            return allergenService.GetOneAllergen(allergenId);
        }

        public List<Allergen> GetAllAllergen()
        {
            return allergenService.GetAllAllergen();
        }

        public void CreateAllergen(Allergen allergen)
        {
            allergenService.CreateAllergen(allergen);
        }

        public void DeleteAllergen(int allergenId)
        {
            allergenService.DeleteAllergen(allergenId);
        }

        public void UpdateAllergen(Allergen allergen)
        {
            allergenService.UpdateAllergen(allergen);
        }
        public List<Allergen> GetAllergensForPatient(String PatientUserName)
        {
            return allergenService.GetAllergensForPatient(PatientUserName);
        }
        public int getNextId()
        {
            return allergenService.getNextId();
        }

    }
}
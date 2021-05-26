/***********************************************************************
 * Module:  Allergen.cs
 * Author:  pc
 * Purpose: Definition of the Class Bolnica.Model.Allergen
 ***********************************************************************/

using System;

namespace Bolnica.Model
{
    public class Allergen
    {
        public Drug drug;
        public Patient patient;
        public int AllergenId;
        public bool deleted;

        public Allergen(int Id, String drug, String patientUserName)
        {
            AllergenId = Id;
            patient = new Patient(patientUserName);
            this.drug = new Drug(drug);
            deleted = false;
        }
        public String getDrug()
        {
            return drug.DrugName;    
        }
        public String getPatient()
        {
            return patient.User.Username;
        }
        public int getAllergenId()
        {
            return AllergenId;
        }
        public void delete()
        {
            deleted = true;
        }
        public bool isDeleted()
        {
            return deleted;
        }
        public void UpdateAllergen(Allergen allergen)
        {
            this.patient = new Patient(allergen.getPatient());
            this.drug = new Drug(allergen.getDrug());
        }
    }
}
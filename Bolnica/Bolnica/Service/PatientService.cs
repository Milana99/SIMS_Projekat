using System;
using System.Collections.Generic;

namespace Bolnica.Service
{
   public class PatientService
   {
        public Bolnica.Repository.PatientRepository patientRepository;

        public PatientService()
        {
            patientRepository = new Repository.PatientRepository(@"C:\Users\pc\OneDrive\Radna površina\Radovan\Upravnik\Patient.txt");
        }
        public List<Model.Patient> GetAllPatients()
      {
            return patientRepository.LoadPatient();
      }
      
      public Model.Patient GetOnePatient(String username)
      {
            List<Model.Patient> patients = GetAllPatients();
            foreach(Model.Patient pa in patients)
            {
                if (pa.User.Username == username)
                {
                    return pa;
                }
            }
            return null;
      }
      
      public void CreatePatient(String name, String surname, String username, String password, String phoneNumber, String email, Model.Gender gender, long jmbg, DateTime dateOfBirth, String address, int lbo, int bzk)
      {
         // TODO: implement
      }
      
      public void DeletePatient(String username)
      {
         // TODO: implement
      }
      
      public void UpdatePatient(int name, int surname, int phoneNumber, int email, int address)
      {
         // TODO: implement
      }
   

   
   }
}
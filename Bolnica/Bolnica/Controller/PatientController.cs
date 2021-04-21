using System;
using System.Collections.Generic;

namespace Bolnica.Controller
{
   public class PatientController
   {
        public Bolnica.Service.PatientService patientService;

        public PatientController()
        {
            patientService = new Service.PatientService();
        }
        public List<Model.Patient> GetAllPatients()
      {
            return patientService.GetAllPatients();
      }
      
      public Model.Patient GetOnePatient(String username)
      {
            return patientService.GetOnePatient(username);
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
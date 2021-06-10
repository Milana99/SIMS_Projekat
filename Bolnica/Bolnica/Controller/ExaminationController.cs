using System;
using System.Collections.Generic;

namespace Bolnica.Controller
{
   public class ExaminationController
   {

        public Bolnica.Service.ExaminationService examinationService;

        public ExaminationController()
        {
            examinationService = new Service.ExaminationService();
        }
        public List<Model.Examination> GetAllExaminations()
      {
            return examinationService.GetAll();
      }
      
      public Model.Examination GetOneExamination(int examinationId)
      {
            return examinationService.GetOne(examinationId);
      }
      
      public Boolean CreateExamination(Model.Examination NewExamination)
      {
            return examinationService.Create(NewExamination);
      }
      
      public void DeleteExamination(int examinationId)
      {
            examinationService.Delete(examinationId);
      }
      
      public Boolean UpdateExamination(int examinationId, DateTime startTime, DateTime endTime, int roomId)
      {
            return examinationService.Update(examinationId, startTime, endTime, roomId);
      }
      
      public List<Model.Examination> GetExaminatonsForDoctor(String doctorUsername)
      {
            return examinationService.GetExaminatonsForDoctor(doctorUsername);
      }
      
      public List<Model.Examination> GetExaminationForPatient(String patientUsername)
      {
            return examinationService.GetExaminationForPatient(patientUsername);
      }
      
      public void NotifyPatientBySecretary(String patientEmail)
      {
         // TODO: implement
      }
      
      public void NotifyDoctorBySecretary(String doctorEmail)
      {
         // TODO: implement
      }
   
      
   
   }
}
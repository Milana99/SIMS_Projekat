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
            return examinationService.GetAllExaminations();
      }
      
      public Model.Examination GetOneExamination(int examinationId)
      {
            return examinationService.GetOneExamination(examinationId);
      }
      
      public Boolean CreateExamination(int examinationId, DateTime startTime, DateTime endTime, Model.ExaminationType examinationType, String doctorUsername, String patientUsername, int room)
      {
            return examinationService.CreateExamination(examinationId, startTime, endTime, examinationType, doctorUsername, patientUsername, room);
      }
      
      public void DeleteExamination(int examinationId)
      {
            examinationService.DeleteExamination(examinationId);
      }
      
      public Boolean UpdateExamination(int examinationId, DateTime startTime, DateTime endTime)
      {
            return examinationService.UpdateExamination(examinationId, startTime, endTime);
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
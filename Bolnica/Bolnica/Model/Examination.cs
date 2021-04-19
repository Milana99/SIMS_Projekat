using System;

namespace Bolnica.Model
{
   public class Examination
   {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ExaminationType ExaminationType { get; set; }
        public Patient patient { get; set; }
        public Doctor doctor { get; set; }
        public int room { get; set; }
        public int ExaminationId { get; set; }
        public bool deleted { get; set; }
        
        public Examination(int newExaminationId, DateTime newStartTime, DateTime newEndTime, string newDoctor, string newPatient, int newRoom)
        {
            
            ExaminationId = newExaminationId;
            StartTime = newStartTime;
            EndTime = newEndTime;
            doctor = new Doctor(newDoctor);
            
            patient = new Patient(newPatient);
            room = newRoom;
            deleted = false;

        }

        public void SaveNewExamination(int examinationId, DateTime startTime, DateTime endTime, int patientId, int doctorId)
      {
         // TODO: implement
      }
      
      public void DeleteExamination()
      {
            deleted = true;
      }
      
      public void UpdateExamination(DateTime newStartTime, DateTime newEndTime)
      {
            StartTime = newStartTime;
            EndTime = newEndTime;
      }
      
      public Examination GetExamination()
      {
            return null;
      }

      public Doctor GetDoctor()
      {
         return doctor;
      }

      public Patient GetPatient()
      {
         return patient;
      }

      
      public int GetRoom()
      {
         return room;
      }

   }
}
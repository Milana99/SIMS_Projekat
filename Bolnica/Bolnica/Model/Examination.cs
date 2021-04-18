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
        public Room room { get; set; }
        private int ExaminationId { get; set; }
        public bool deleted { get; set; }

        public Examination(int newExaminationId, DateTime newStartTime, DateTime newEndTime, Doctor newDoctor, Patient newPatient, Room newRoom)
        {
            ExaminationId = newExaminationId;
            StartTime = newStartTime;
            EndTime = newEndTime;
            doctor = newDoctor;
            patient = newPatient;
            room = newRoom;
            deleted = false;

        }

        public void SaveNewExamination(int examinationId, DateTime startTime, DateTime endTime, int patientId, int doctorId)
      {
         // TODO: implement
      }
      
      public void DeleteExamination()
      {
         // TODO: implement
      }
      
      public void UpdateExamination(DateTime newStartTime, DateTime newEndTime)
      {
         // TODO: implement
      }
      
      public Examination GetExamination()
      {
         // TODO: implement
         return null;
      }

      public Doctor GetDoctor()
      {
         return doctor;
      }

      public void SetDoctor(Doctor newDoctor)
      {
         if (this.doctor != newDoctor)
         {
            if (this.doctor != null)
            {
               Doctor oldDoctor = this.doctor;
               this.doctor = null;
               oldDoctor.RemoveExaminations(this);
            }
            if (newDoctor != null)
            {
               this.doctor = newDoctor;
               this.doctor.AddExaminations(this);
            }
         }
      }

      public Patient GetPatient()
      {
         return patient;
      }
      
      public void SetPatient(Patient newPatient)
      {
         if (this.patient != newPatient)
         {
            if (this.patient != null)
            {
               Patient oldPatient = this.patient;
               this.patient = null;
               oldPatient.RemoveExaminations(this);
            }
            if (newPatient != null)
            {
               this.patient = newPatient;
               this.patient.AddExaminations(this);
            }
         }
      }
     
      
      public Room GetRoom()
      {
         return room;
      }
      

      public void SetRoom(Room newRoom)
      {
         if (this.room != newRoom)
         {
            if (this.room != null)
            {
               Room oldRoom = this.room;
               this.room = null;
               oldRoom.RemoveExamination(this);
            }
            if (newRoom != null)
            {
               this.room = newRoom;
               this.room.AddExamination(this);
            }
         }
      }
   
      
   
   }
}
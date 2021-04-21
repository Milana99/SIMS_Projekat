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
        public int ExaminationId { get; set; }
        public bool deleted { get; set; }
        
        public Examination(int newExaminationId, DateTime newStartTime, DateTime newEndTime, string newDoctor, string newPatient, int newRoomId)
        {
            
            ExaminationId = newExaminationId;
            StartTime = newStartTime;
            EndTime = newEndTime;
            doctor = new Doctor(newDoctor);
            
            patient = new Patient(newPatient);
            room = new Room(newRoomId);
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

      
      public Room GetRoom()
      {
         return room;
      }

        public void SetDoctor(Doctor newDoctor)
        {
            if (this.doctor != newDoctor)
            {
                if (this.doctor != null)
                {
                    Doctor oldDoctor = this.doctor;
                    this.doctor = null;
                }
                if (newDoctor != null)
                {
                    this.doctor = newDoctor;
                }
            }
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
/***********************************************************************
 * Module:  InstructionsForHospitalTreatment.cs
 * Author:  pc
 * Purpose: Definition of the Class Bolnica.Model.InstructionsForHospitalTreatment
 ***********************************************************************/

using System;

namespace Bolnica.Model
{
    public class InstructionsForHospitalTreatment
    {
        public int Id { get; set; }
        public Patient patient { get; set; }
        public Model.Room room { get; set; }
        public StaticEquipment Bed { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        private bool deleted { get; set; }

        public InstructionsForHospitalTreatment(int id, String Patient, int RoomId, int BedId, DateTime StartDate, DateTime EndDate)
        {
            
            Id = id;
            patient = new Patient(Patient);
            room = new Room(RoomId);
            Controller.StaticEquipmentController staticEquipmentController = new Controller.StaticEquipmentController();
            Bed = staticEquipmentController.GetOneStaticEquipment(BedId);
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            deleted = false;
        }
        public int GetRoom()
        {
            return room.RoomId;
        }
        public bool getDeleted()
        {
            return deleted;
        }
        public int getId()
        {
            return Id;
        }
        public String getPatient()
        {
            return patient.User.Username;
        }
        public int getBed()
        {
            return Bed.StaticEquipmentId;
        }
        public DateTime getStartDate()
        {
            return StartDate;
        }
        public DateTime getEndDate()
        {
            return EndDate;
        }
        public void UpdateEndDate(DateTime newEndDate)
        {
            EndDate = newEndDate;
        }
        public void deleteInstruction()
        {
            deleted = true;
        }
    }
}
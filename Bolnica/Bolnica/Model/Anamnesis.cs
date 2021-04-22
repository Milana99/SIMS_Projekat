using System;

namespace Bolnica.Model
{
   public class Anamnesis
   {
        public Patient patient { get; set; }
        public int AnamnesisId { get; set; }
        public String TypeAnamnesis { get; set; }
        public String NameAnamnesis { get; set; }
        public String DescriptionAnamnesis { get; set; }
        public String OpinionForAnamnesis { get; set; }

        public bool deleted { get; set; }

        public Anamnesis(String PatientUserName, int AnamId, String AnamType, String Description, String Opinion)
        {
            patient = new Patient(PatientUserName);
            AnamnesisId = AnamId;
            TypeAnamnesis = AnamType;
            DescriptionAnamnesis = Description;
            OpinionForAnamnesis = Opinion;
            deleted = false;
        }
        public Anamnesis(int id)
        {
            AnamnesisId = id;
        }

    }
}
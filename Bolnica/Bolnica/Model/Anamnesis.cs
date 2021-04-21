using System;

namespace Bolnica.Model
{
   public class Anamnesis
   {
        public Therapy therapy { get; set; }
        public int AnamnesisId { get; set; }
        public String TypeAnamnesis { get; set; }
        public String NameAnamnesis { get; set; }
        public String DescriptionAnamnesis { get; set; }
        public String OpinionForAnamnesis { get; set; }

    }
}
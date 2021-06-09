using System;
using System.Collections.Generic;
using System.IO;
namespace Bolnica.Repository

{
   public class AnamnesisRepository : Repository<Model.Anamnesis>
   {
        public int next_id;
        public AnamnesisRepository(String fileLocation): base(fileLocation){}

        public override Model.Anamnesis addOne(string[] words)
        {
            Model.Anamnesis anamnesis = new Model.Anamnesis(words[0], int.Parse(words[1]), words[2], words[3], words[4]);
            next_id = anamnesis.AnamnesisId;
            next_id++;
            return anamnesis;
        }

        public override String getOne(Model.Anamnesis anamnesis)
        {
            if (anamnesis.deleted == false)
            {
                String line = anamnesis.patient.User.Username + "," + anamnesis.AnamnesisId + "," + anamnesis.TypeAnamnesis + "," + anamnesis.DescriptionAnamnesis + "," + anamnesis.OpinionForAnamnesis;

                return line;
            }
            return null;
        }
        
   }
}
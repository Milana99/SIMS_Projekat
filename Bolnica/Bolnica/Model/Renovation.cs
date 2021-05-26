/***********************************************************************
 * Module:  Renovation.cs
 * Author:  pc
 * Purpose: Definition of the Class Bolnica.Model.Renovation
 ***********************************************************************/

using System;

namespace Bolnica.Model
{
    public class Renovation
    {
        
        public int RenovationId { get; set; }
       
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        
        public bool deleted { get; set; }

        public Renovation(int RenovationId, DateTime Start, DateTime End)
        {
            this.RenovationId = RenovationId;
            StartTime = Start;
            EndTime = End;
            
            deleted = false;
        }

    }
}
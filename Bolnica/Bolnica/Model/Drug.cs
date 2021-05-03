using System;

namespace Bolnica.Model
{
   public class Drug
   {
        public int DrugId { get; set; }
        public String DrugName { get; set; }
        public String DescriptionDrug { get; set; }
        public int QuantityDrug { get; set; }
        public double WeightDrug { get; set; }
        private String ComponentsDrug;
        private bool ApprovedDrug;

        public Drug(String Name)
        {
            DrugName = Name;
        }

    }
}
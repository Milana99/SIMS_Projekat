using System;

namespace Bolnica.Model
{
   public class Drug
   {
        public int DrugId { get; set; }
        public String DrugName { get; set; }
        public String DrugDescription { get; set; }
        public int DrugQuantity { get; set; }
        public double DrugWeight { get; set; }
        public String DrugComponents { get; set; }
        public TypeOfApprovedDrug DrugType { get; set; }
        public String AlternativeDrug { get; set; }
        public String DrugComment { get; set; }
        public Drug(int drugId, string drugName, string drugDescription, int drugQuantity, double drugWeight, string drugComponents, TypeOfApprovedDrug drugType, string alternativeDrug, string comment)
        {
            DrugId = drugId;
            DrugName = drugName;
            DrugDescription = drugDescription;
            DrugQuantity = drugQuantity;
            DrugWeight = drugWeight;
            DrugComponents = drugComponents;
            DrugType = drugType;
            AlternativeDrug = alternativeDrug;
            DrugComment = comment;
        }
        public Drug(string drugName)
        {
            DrugName = drugName;
        }
    }
}
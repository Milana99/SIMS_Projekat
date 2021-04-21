using System;
using System.Collections.Generic;

namespace Bolnica.Controller
{
   public class DrugController
   {
        public Bolnica.Service.DrugService drugService;

        public List<Model.Drug> GetAllDrugs()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Drug GetOneDrug(int drugId)
      {
         // TODO: implement
         return null;
      }
      
      public void CreateDrug(int drugId, String name, String description, int quantity, double weight)
      {
         // TODO: implement
      }
      
      public void UpdateDrug(int drugId, String name, String description, int quiantity, double weight)
      {
         // TODO: implement
      }
      
      public void DeleteDrug(int drugId)
      {
         // TODO: implement
      }
   
     
   
   }
}
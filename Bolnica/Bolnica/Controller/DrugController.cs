using System;
using System.Collections.Generic;

namespace Bolnica.Controller
{
    public class DrugController
    {
        public Bolnica.Service.DrugService drugService;

        public DrugController()
        {
            drugService = new Service.DrugService();
        }

        public List<Model.Drug> GetAllDrugs()
        {
            return drugService.GetAll();
      }

        public Model.Drug GetOneDrug(int drugId)
        {
            return drugService.GetOne(drugId);
        }

        public Model.Drug GetDrugByName(string Name)
        {
            return drugService.GetDrugByName(Name);
        }

        public void CreateDrug(Model.Drug drug)
        {
            drugService.Create(drug);
        }

        public void UpdateDrug(Model.Drug drug)
        {
            drugService.Update(drug);
        }
        public void DenyDrug(int drugId, String comment)
        {
            drugService.DenyDrug(drugId, comment);
        }
        public void ApproveDrug(int drugId)
        {
            drugService.ApproveDrug(drugId);
        }
        public void DeleteDrug(int drugId)
        {
            drugService.Delete(drugId);
        }



    }
}
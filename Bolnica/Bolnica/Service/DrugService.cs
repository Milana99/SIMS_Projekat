using System;
using System.Collections.Generic;

namespace Bolnica.Service
{
    public class DrugService
    {
        public Bolnica.Repository.DrugRepository drugRepository;

        public DrugService()
        {
            drugRepository = new Repository.DrugRepository(@"C:\Users\pc\OneDrive\Radna površina\Radovan\Upravnik\Drug.txt");
        }
        public List<Model.Drug> GetAllDrugs()
        {
            return drugRepository.LoadDrug();
        }

        public Model.Drug GetOneDrug(int drugId)
        {
            List<Model.Drug> drugs = GetAllDrugs();
            foreach (Model.Drug drug in drugs)
            {
                if (drugId == drug.DrugId)
                {
                    return drug;
                }
            }
            return null;
        }

        public void CreateDrug(Model.Drug drug)
        {
            List<Model.Drug> drugs = GetAllDrugs();
            drugs.Add(drug);
            drugRepository.SaveDrug(drugs);
        }

        public void UpdateDrug(Model.Drug changedDrug)
        {
            List<Model.Drug> drugs = GetAllDrugs();
            foreach (Model.Drug drug in drugs)
            {
                if (drug.DrugId == changedDrug.DrugId)
                {
                    drug.DrugName = changedDrug.DrugName;
                    drug.DrugQuantity = changedDrug.DrugQuantity;
                    drug.DrugType = changedDrug.DrugType;
                    drug.DrugWeight = changedDrug.DrugWeight;
                    drug.DrugDescription = changedDrug.DrugDescription;
                    drug.DrugComponents = changedDrug.DrugComponents;
                    drug.AlternativeDrug = changedDrug.AlternativeDrug;
                    drug.DrugComment = changedDrug.DrugComment;
                    drugRepository.SaveDrug(drugs);
                    return;
                }
            }
        }
        public void DenyDrug(int drugId)
        {
            List<Model.Drug> drugs = GetAllDrugs();
            foreach (Model.Drug drug in drugs)
            {
                if (drugId == drug.DrugId)
                {
                    drug.DrugType = Model.TypeOfApprovedDrug.NotApproved;
                    drugRepository.SaveDrug(drugs);
                    return;
                }
            }
        }
        public void ApproveDrug(int drugId)
        {
            List<Model.Drug> drugs = GetAllDrugs();
            foreach (Model.Drug drug in drugs)
            {
                if (drugId == drug.DrugId)
                {
                    drug.DrugType = Model.TypeOfApprovedDrug.Approved;
                    drugRepository.SaveDrug(drugs);
                    return;
                }
            }
        }
        public void DeleteDrug(int drugId)
        {
            List<Model.Drug> drugs = GetAllDrugs();
            foreach (Model.Drug drug in drugs)
            {
                if (drugId == drug.DrugId)
                {
                    drug.DrugType = Model.TypeOfApprovedDrug.Deleted;
                    drugRepository.SaveDrug(drugs);
                    return;
                }
            }
        }


    }
}
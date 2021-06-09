using System;
using System.Collections.Generic;
using Bolnica.ServiceInterface;

namespace Bolnica.Service
{
    public class DrugService : IUsingRepo<Model.Drug>
    {
        public Bolnica.Repository.DrugRepository drugRepository;

        public DrugService()
        {
            drugRepository = new Repository.DrugRepository(@"C:\Users\pc\OneDrive\Radna površina\Radovan\Upravnik\Drug.txt");
        }
        public List<Model.Drug> GetAll()
        {
            return drugRepository.LoadDrug();
        }

        public Model.Drug GetOne(int drugId)
        {
            List<Model.Drug> drugs = GetAll();
            foreach (Model.Drug drug in drugs)
            {
                if (drugId == drug.DrugId)
                {
                    return drug;
                }
            }
            return null;
        }
        public Model.Drug GetDrugByName(string Name)
        {
            List<Model.Drug> drugs = GetAll();
            foreach (Model.Drug drug in drugs)
            {
                if (Name == drug.DrugName)
                {
                    return drug;
                }
            }
            return null;
        }

        public void Create(Model.Drug drug)
        {
            List<Model.Drug> drugs = GetAll();
            drugs.Add(drug);
            drugRepository.SaveDrug(drugs);
        }

        public void Update(Model.Drug changedDrug)
        {
            List<Model.Drug> drugs = GetAll();
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
        public void DenyDrug(int drugId, String comment)
        {
            List<Model.Drug> drugs = GetAll();
            foreach (Model.Drug drug in drugs)
            {
                if (drugId == drug.DrugId)
                {
                    drug.DrugComment = comment;
                    drug.DrugType = Model.TypeOfApprovedDrug.NotApproved;
                    drugRepository.SaveDrug(drugs);
                    return;
                }
            }
        }
        public void ApproveDrug(int drugId)
        {
            List<Model.Drug> drugs = GetAll();
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
        public void Delete(int drugId)
        {
            List<Model.Drug> drugs = GetAll();
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
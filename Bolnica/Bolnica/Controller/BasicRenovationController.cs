
using System;
using System.Collections.Generic;
using Bolnica.Model;
namespace Bolnica.Controller
{
   public class BasicRenovationController
   {
        public Service.BasicRenovationService renovationService;

        public BasicRenovationController()
        {
            renovationService = new Service.BasicRenovationService();
        }
      public BasicRenovation GetOneRenovation(int renovationId)
      {
            return renovationService.GetOne(renovationId);
      }
      
      public List<BasicRenovation> GetAllRenovations()
      {
            return renovationService.GetAll();
      }
      
      public void CreateRenovation(BasicRenovation renovation)
      {
            renovationService.Create(renovation);
      }
      
      public void DeleteRenovation(int renovationId)
      {
            renovationService.Delete(renovationId);
      }
      
      public void UpdateRenovation(BasicRenovation renovation)
      {
            renovationService.Update(renovation);
      }
   
      
   
   }
}
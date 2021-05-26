
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
            return renovationService.GetOneRenovation(renovationId);
      }
      
      public List<BasicRenovation> GetAllRenovations()
      {
            return renovationService.GetAllRenovations();
      }
      
      public void CreateRenovation(BasicRenovation renovation)
      {
            renovationService.CreateRenovation(renovation);
      }
      
      public void DeleteRenovation(int renovationId)
      {
            renovationService.DeleteRenovation(renovationId);
      }
      
      public void UpdateRenovation(BasicRenovation renovation)
      {
            renovationService.UpdateRenovation(renovation);
      }
   
      
   
   }
}
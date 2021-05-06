
using System;
using System.Collections.Generic;
using Bolnica.Model;
namespace Bolnica.Controller
{
   public class RenovationController
   {
        public Service.RenovationService renovationService;

        public RenovationController()
        {
            renovationService = new Service.RenovationService();
        }
      public Renovation GetOneRenovation(int renovationId)
      {
            return renovationService.GetOneRenovation(renovationId);
      }
      
      public List<Renovation> GetAllRenovations()
      {
            return renovationService.GetAllRenovations();
      }
      
      public void CreateRenovation(Renovation renovation)
      {
            renovationService.CreateRenovation(renovation);
      }
      
      public void DeleteRenovation(int renovationId)
      {
            renovationService.DeleteRenovation(renovationId);
      }
      
      public void UpdateRenovation(Renovation renovation)
      {
            renovationService.UpdateRenovation(renovation);
      }
   
      
   
   }
}
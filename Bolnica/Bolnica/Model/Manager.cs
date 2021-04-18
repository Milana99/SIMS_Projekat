using System;
using System.Collections.Generic;

namespace Bolnica.Model
{
   public class Manager : Employee
   {
      public List<Room> Room;

        
        public Manager(User newUser, double newSalary, double newWorkingHours) : base(newUser, newSalary, newWorkingHours) { }

    }
}
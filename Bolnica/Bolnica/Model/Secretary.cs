using System;

namespace Bolnica.Model
{
   public class Secretary : Employee
   {
        public Secretary(User newUser, double newSalary, double newWorkingHours) : base(newUser, newSalary, newWorkingHours) { }
    }
}
using System;

namespace Bolnica.Model
{
   public class Employee
   {
      public User User { get; set; }
        protected double Salary { get; set; }
        protected double WorkingHours { get; set; }

        public Employee(User newUser, double newSalary, double newWorkingHours)
        {
            User = newUser;
            Salary = newSalary;
            WorkingHours = newWorkingHours;
        }

        public Employee(String newUsername)
        {
            User = new User(newUsername);
        }

    }
}
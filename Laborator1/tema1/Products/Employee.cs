using System;
namespace Products
{
     abstract class Employee
    {
        
        public Guid Id{ get; private set; }

        public string FirstName{get; private set;}

        public string LastName {get; private set;}

        public DateTime StartDate {get; private set;}

        public DateTime EndDate {get; private set; }

        public double Salary {get; private set; }

        public abstract string GetFullName();

        public abstract bool IsActive();

        public abstract string Salutation();
    }
}
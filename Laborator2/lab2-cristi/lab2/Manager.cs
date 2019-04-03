using System;
namespace Products
{
     public class Manager : Employee
    {
        private const string  ManagerSalutation = "Hello Manager";

        private Manager()
        {
            
        }
        public override string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public override bool IsActive()
        {
            return EndDate > DateTime.Now;
        }

        public override string Salutation()
        {
            return ManagerSalutation;
        }

        public static Manager Create( )// trebuie sa faci la fel ca la product
        {
            return new Manager();
        }
    }
}
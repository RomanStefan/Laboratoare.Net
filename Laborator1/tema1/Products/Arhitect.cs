using System;
namespace Products
{
     class Arhitect : Employee
    {
          public override string GetFullName()
        {
            return FirstName + LastName;
        }

        public override bool IsActive()
        {
            return EndDate > DateTime.Now;
        }

        public override string Salutation()
        {
            return "Hello Arhitect";
        }
    }
}
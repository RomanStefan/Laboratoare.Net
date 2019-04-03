using System;
namespace Products
{
    //modificator de acces pentru clasa?
     public class Arhitect : Employee
    {
        private const string ArhitectSalutation = "Hello Arhitect";

        private Arhitect()
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
            return ArhitectSalutation;
        }
        public static Arhitect Create()// trebuie sa faci la fel ca la product
        {
            return new Arhitect();
        }
    }
}
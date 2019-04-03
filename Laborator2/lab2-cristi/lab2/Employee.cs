using System;
namespace Products
{
    public abstract class Employee
    {

        /*
        public Guid Id{ get; private set; }
        */
        // folosesti protected peste tot in loc de private
        public Guid Id { get; protected set; }

        public string FirstName { get; protected set; }

        public string LastName { get; protected set; }

        public DateTime StartDate { get; protected set; }

        public DateTime EndDate { get; protected set; }

        public double Salary { get; protected set; }

        public abstract string GetFullName();

        public abstract bool IsActive();

        public abstract string Salutation();
    }
}
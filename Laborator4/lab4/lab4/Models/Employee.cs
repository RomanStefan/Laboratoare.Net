using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace lab4
{
    [Table("Employees")]
    public class Employee
    {
        public Guid Id { get; private set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; private set; }

        [Required]
        [StringLength(70)]
        public string LastName { get; private set; }

        [Required]
        public DateTime StartDate { get; private set; }

        public DateTime? EndDate { get; private set; }

        public bool IsActive { get; private set; }

        public int Salary { get; private set; }

        private Employee()
        {

        }

        public static Employee Create(string firstname, string lastname, DateTime stardate, DateTime enddate,
            bool isactive, int salary)
        {
            return new Employee
            {
                Id = Guid.NewGuid(),
                FirstName = firstname,
                LastName = lastname,
                StartDate = stardate,
                EndDate = enddate,
                IsActive = isactive,
                Salary = salary,
            };
        }

    }
}

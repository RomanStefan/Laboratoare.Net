using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace lab4
{
    [Table("Customers")]
    public class Customer
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Address { get; private set; }

        public int PhoneNumber { get; private set; }

        public string Email { get; private set; }

        private Customer()
        {
            //EF magic:))
        }

        public static Customer Create(string name, string address, int phoneNumber, string email)
        {
            return new Customer
            {
                Id = Guid.NewGuid(),
                Name = name,
                Address = address,
                PhoneNumber = phoneNumber,
                Email = email,
            };
        }

        public void Update(string name)
        {
            this.Name = name;
        }
    }
}
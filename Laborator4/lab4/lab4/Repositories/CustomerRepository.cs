using System;
using System.Collections.Generic;
using System.Linq;

namespace lab4.Repositories
{
    public class CustomerRepository
    {
        private readonly ApplicationContext context;

        public CustomerRepository(ApplicationContext context)
        {
            this.context = context;
        }

        //Create
        public void Create(Customer customer)
        {
            this.context.Customers.Add(customer);
            this.context.SaveChanges();
        }

        //update
        public void Update(Customer customer)
        {
            this.context.Customers.Update(customer);
            this.context.SaveChanges();
        }

        //Delete
        public void Delete(Guid id)
        {
            Customer customer = this.context.Customers.Find(id);
            this.context.Customers.Remove(customer);
            this.context.SaveChanges();
        }

        public Customer GetById(Guid id)
        {
            return this.context.Customers.Find(id);
        }

        //GetAll
        public IEnumerable<Customer> GetAll()
        {
            return this.context.Customers.ToList();
        }

        //GetCustomerByEmail
        public Customer GetCustomerByEmail(string email)
        {
            //method syntax
            /*var query = this.context.Customers
                .Where(customer => customer.Email == email);
            return query; */

            return this.context.Customers.FirstOrDefault(customer => customer.Email == email);
        }
    }
}

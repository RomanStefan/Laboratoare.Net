using System;
using lab4;
using lab4.Repositories;

namespace Lab4Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var demo = new ApplicationContext();

            var customerRepository = new CustomerRepository(demo);

            var Customer1 = Customer.Create("Test Customer Name1", "Test Address", 123, "Test EMail.com");

            var Customer2 = Customer.Create("Test Customer Name2", "My Address", 1234, "laos@gmail.com");

            customerRepository.Create(Customer2);
        }
    }
}

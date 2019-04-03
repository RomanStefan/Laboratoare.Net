using System;
using System.Collections.Generic;
using System.Linq;

namespace lab4.Repositories
{
    public class EmployeeRepository
    {
        private readonly ApplicationContext context;

        EmployeeRepository(ApplicationContext context)
        {
            this.context = context;
        }

        //Create
        public void Create(Employee employee)
        {
            this.context.Empoloyees.Add(employee);
            this.context.SaveChanges();
        }

        //Update
        public void Update(Employee employee)
        {
            this.context.Empoloyees.Update(employee);
            this.context.SaveChanges();
        }

        //Delete
        public void Delete(Guid id)
        {
            Employee employee = this.context.Empoloyees.Find(id);
            this.context.Empoloyees.Remove(employee);
            this.context.SaveChanges();
        }

        //GetById

        public Employee GetById(Guid id)
        {
            return this.context.Empoloyees.Find(id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return this.context.Empoloyees.ToList();
        }

        public IEnumerable<Employee> GetEmployeesBySalary(int salary)
        {
            //method syntax
            var query = this.context.Empoloyees
                .Where(employee => employee.Salary == salary);
            return query; 

        }
    }
}

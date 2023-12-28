using DependencyInjection.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.DAL
{
    internal class EmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>
            {
                new Employee() { Id = 1, Name = "Daniel", Department = "IT" },
                new Employee() { Id = 2, Name = "Amaro", Department = "HR" },
                new Employee() { Id = 3, Name = "Wladimir", Department = "Payroll" }
            };

            return ListEmployees;
        }

    }
}

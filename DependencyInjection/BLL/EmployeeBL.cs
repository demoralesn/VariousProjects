using DependencyInjection.DAL;
using DependencyInjection.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.BLL
{
    internal class EmployeeBL
    {
        public EmployeeDAL employeeDAL { get; set; }
        public List<Employee> GetAllEmployees()
        {
            employeeDAL = new EmployeeDAL();

            return employeeDAL.SelectAllEmployees();
        }
    }
}

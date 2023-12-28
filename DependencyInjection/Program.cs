using DependencyInjection.BLL;
using DependencyInjection.DAL;
using DependencyInjection.Model;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new class instance
            EmployeeBL employeeBL = new EmployeeBL();
            //Dependency Injection of PatientDAL class into PatientBL class
            PatientBL patientBL = new PatientBL(new PatientDAL());

            List<Employee> listEmployee = employeeBL.GetAllEmployees();
            List<Patient> listPatient = patientBL.GetAllPatients();

            foreach (Employee emp in listEmployee)
            {
                Console.WriteLine($"ID = {emp.Id}, Name = {emp.Name}, Department = {emp.Department}");
            }

            foreach (Patient pat in listPatient)
            {
                Console.WriteLine($"ID = {pat.Id}, Name = {pat.Name}, Address = {pat.Address}");
            }

            Console.ReadKey();
        }
    }
}
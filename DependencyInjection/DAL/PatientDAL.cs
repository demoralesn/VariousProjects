using DependencyInjection.IDAL;
using DependencyInjection.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.DAL
{
    internal class PatientDAL : IPatientDAL
    {
        public List<Patient> SelectAllPatients()
        {
            List<Patient> ListPatients = new List<Patient>
            {
                new Patient() { Id = 1, Name = "Daniel", Address = "NA" },
                new Patient() { Id = 2, Name = "Esteban", Address = "NA" },
                new Patient() { Id = 3, Name = "Gonzalo", Address = "NA" }
            };

            return ListPatients;
        }
    }
}

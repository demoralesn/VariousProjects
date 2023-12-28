using DependencyInjection.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.IDAL
{
    internal interface IPatientDAL
    {
        List<Patient> SelectAllPatients();
    }
}

using DependencyInjection.IDAL;
using DependencyInjection.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.BLL
{
    internal class PatientBL
    {
        IPatientDAL patientDAL;

        internal PatientBL(IPatientDAL patientDAL)
        {
            this.patientDAL = patientDAL;
        }

        internal List<Patient> GetAllPatients()
        {
            return patientDAL.SelectAllPatients();
        }
    }
}

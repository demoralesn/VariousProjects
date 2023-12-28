using Serialization.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.BLL
{
    internal class StudentBL
    {
        List<Student>? studentList;

        internal List<Student> getStudents()
        {
            studentList = new List<Student>
            {
                new Student { IdStudent = 1, Name = "Daniel", Age = 36 },
                new Student { IdStudent = 2, Name = "Wladimir", Age = 12}
            };

            return studentList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreConsole.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int? GradeId { get; set; }//nullable
        public Grade Grade { get; set; }

        public StudentAddress Address { get; set; }

    }

}

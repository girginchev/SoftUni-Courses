using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorGroup
{
    public class Student
    {
        public Student()
        {
            Comments = new List<string>();
            Dates = new List<DateTime>();
        }
        public List<string> Comments { get; set; }

        public List<DateTime> Dates { get; set; }
    }
}

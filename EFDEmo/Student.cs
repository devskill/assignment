using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFDEmo
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<Course> Courses { get; set; }
    }
}

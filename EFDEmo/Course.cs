using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFDEmo
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}

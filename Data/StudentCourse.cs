using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class StudentCourse
    {
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
    }
}

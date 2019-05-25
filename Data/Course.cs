using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class Course
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required, DataType(DataType.Text), StringLength(255)]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        public virtual ICollection<StudentCourse> CourseStudents { get; set; }
        public virtual ICollection<CourseTopic> Topics { get; set; }
    }
}

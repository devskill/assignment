using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class CourseTopic
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required, DataType(DataType.Text), StringLength(255)]
        public string Name { get; set; }

        [Required, DataType(DataType.Text), StringLength(2000)]
        public string Description { get; set; }

        public Guid CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}

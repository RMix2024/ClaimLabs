using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Grade_Manager_Razor
{
    public class Assignment
    {
        [Key]
        public int AssignmentId { get; set; }

        [Required]
        public string Name { get; set; }
        public bool IsComplete { get; set; } = false;
        public double Grade { get; set; } = 0;

        [ForeignKey("StudentId")]
        public int StudentId { get; set; }

        public Student Student { get; set; }

    }
}

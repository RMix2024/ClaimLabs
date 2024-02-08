using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Grade_Manager_Razor.Data;

namespace Grade_Manager_Razor.Models
{
    public class AddAssignmentViewModel
    {

        [Key]
        public int AssignmentId { get; set; }

        [Required]
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public double Grade { get; set; }

        public int StudentId { get; set; }

        public Student Student { get; set; }


        public Assignment ToAssignment()
        {
            return new Assignment
            {
                Name = Name,
                AssignmentId = AssignmentId,
                IsComplete = IsComplete,
                Grade = Grade,
                StudentId = StudentId
            };
        }

    }
}

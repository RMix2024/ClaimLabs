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
    public class AddStudentViewModel
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; }
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

        public int ClassRoomId { get; set; }


        public Student ToStudent()
        {
            return new Student
            {
                Name = Name,
                ClassRoomId = ClassRoomId
               
            };
        }
    }
}

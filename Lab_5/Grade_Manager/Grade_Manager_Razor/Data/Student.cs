using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Grade_Manager_Razor
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

        [ForeignKey("ClassRoomId")]
        public int ClassRoomId { get; set; }

        public ClassRoom ClassRoom { get; set; }



    }
}

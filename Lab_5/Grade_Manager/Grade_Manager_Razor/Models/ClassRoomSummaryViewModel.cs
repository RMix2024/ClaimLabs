using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grade_Manager_Razor.Models
{
    public class ClassRoomSummaryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Student> Assignments { get; set; } = new List<Student>();

        public int StudentId { get; set; }

        public Student Student { get; set; }

    }
}

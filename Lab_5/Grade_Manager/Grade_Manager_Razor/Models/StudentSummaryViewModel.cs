using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grade_Manager_Razor.Models
{
    public class StudentSummaryViewModel
    {

        public int StudentId { get; set; }       
        public string Name { get; set; }
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public int ClassRoomId { get; set; }

    }
}

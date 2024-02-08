using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grade_Manager_Razor.Models
{
    public class AssignmentSummaryViewModel
    {        
        public int AssignmentId { get; set; }       
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public double Grade { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

    }
}

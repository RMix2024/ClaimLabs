using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grade_Manager_Razor.Models
{
    public class GradeAssignmentViewModel
    {
        public int Id { get; set; }

        public void GradeAnAssignment(Assignment assignment)
        {
            assignment.Grade = assignment.Grade;
            assignment.IsComplete = assignment.IsComplete;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grade_Manager_Razor.Data;
using Grade_Manager_Razor.Models;
using Microsoft.Extensions.Logging;

namespace Grade_Manager_Razor
{
    public class AssignmentService
    {

        readonly GradeManagerDbContext _context;
        readonly ILogger _logger;

        public AssignmentService(GradeManagerDbContext context, ILoggerFactory factory)
        {
            this._context = context;
            _logger = factory.CreateLogger<AssignmentService>();
        }



        public List<Assignment> GetFilteredAssignments(int id)
        {
            List<Assignment> assignments = new List<Assignment>();

            var assignmentList = _context.Assignments
                .Where(x => x.StudentId == id);
            foreach (var assignment in assignmentList)
            {
                assignments.Add(assignment);
            }
            return assignments;

        }

        public Assignment AddNewAssignment(AddAssignmentViewModel name)
        {
            var assignment = name.ToAssignment();

            _context.Add(assignment);
            _context.SaveChanges();

            return assignment;

        }

        public Assignment GetFilteredAssignmentToDelete(int id)
        {
            return this._context.Assignments.Where(x => x.AssignmentId == id).FirstOrDefault();

        }

        public void GradeAssignment(GradeAssignmentViewModel gavm)
        {
            var assignment = _context.Assignments.Find(gavm.Id);
            gavm.GradeAnAssignment(assignment);
            _context.SaveChanges();
        }

        public double AssignmentsAverage(int id)
        {
            List<Assignment> assignments = new List<Assignment>();
            assignments = GetFilteredAssignments(id);
            double assignmentsAverage = 0;
            foreach (var assignment in assignments)
            {
                assignmentsAverage = assignmentsAverage + assignment.Grade;
            }
            if (assignmentsAverage == 0)
            {
                return 0;
            }
            return assignmentsAverage / assignments.Count;

        }

        public Assignment GetBestAssignment(int id)
        {
            List<Assignment> assignments = new List<Assignment>();
            assignments = GetFilteredAssignments(id);
            Assignment theBestAssignment = new Assignment();
            foreach (var assignment in assignments)
            {
                if (assignment.Grade >= theBestAssignment.Grade)
                {
                    theBestAssignment = assignment;
                }
            }
            return theBestAssignment;
        }

        public Assignment GetWorstAssignment(int id)
        {
            List<Assignment> assignments = new List<Assignment>();
            assignments = GetFilteredAssignments(id);
            Assignment theWorstAssignment = assignments.First();
            foreach (var assignment in assignments)
            {
                if (assignment.Grade <= theWorstAssignment.Grade)
                {
                    theWorstAssignment = assignment;
                }
            }
            return theWorstAssignment;
        }
    }        
}

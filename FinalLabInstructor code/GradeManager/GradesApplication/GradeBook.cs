using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesApplication
{
    public class GradeBook
    {
        public Dictionary<string, Assignment> Assignments { get; }
        public bool AreAllAssingmentsComplete
        {
            get 
            {
                return this.Assignments.Values.All((ass) => ass.IsComplete);
            }
        }

        public GradeBook()
        {
            this.Assignments = new Dictionary<string, Assignment>();
        }

        public void RemoveAssignment(Assignment assignment)
        {
            this.Assignments.Remove(assignment.Name);
        }

        public void RemoveAssignment(string name)
        {
            this.Assignments.Remove(name);
        }

        public void AddAssignment(Assignment assignment)
        {
            this.Assignments.Add(assignment.Name, assignment);
        }

        public void AddAssignment(string name)
        {
            this.Assignments.Add(name, new Assignment(name));
        }

        public Assignment GetAssignment(string name)
        {
            return this.Assignments[name];
        }

        public void GradeAssignment(string assigment, double grade)
        {
            this.Assignments[assigment].Grade = grade;
        }

        public Assignment TopAssignment()
        {
            return this.Assignments.Values.ToList().Max();
        }

        public Assignment WorstAssignment()
        {
            return this.Assignments.Values.ToList().Min();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesApplication
{
    public class Student  : IComparable<Student>
    {
        public string Name { get; private set; }
        public GradeBook Grades { get; private set; }
        public bool HasCompletedAllAssignments 
        { 
            get
            {
                return this.Grades.AreAllAssingmentsComplete;
            }
        }

        public double Average 
        { 
            get
            {
                List<double> grades = new List<double>();
                foreach (Assignment ass in this.Grades.Assignments.Values)
                {
                    if (ass.IsComplete)
                    {
                        grades.Add(ass.Grade);
                    }
                }
                if (grades.Count == 0) return 0;
                return grades.Average();
            }
        }

        public List<Assignment> Assignments 
        {
            get 
            {
                return this.Grades.Assignments.Values.ToList();
            }
        }

        public Student(string name)
        {
            this.Grades = new GradeBook();
            this.Name = name;
        }


        public void Assign(string assignment)
        {
            this.Grades.AddAssignment(assignment);
        }

        public void Unassign(string assignment)
        {
            this.Grades.RemoveAssignment(assignment);
        }

        public void GradeAssignment(string assigment, double grade)
        {
            this.Grades.GradeAssignment(assigment, grade);
        }

        public Assignment TopAssignment()
        {
            return this.Grades.TopAssignment();
        }

        public Assignment WorstAssignment()
        {
            return this.Grades.WorstAssignment();
        }

        static public bool operator <(Student one, Student two)
        {
            return one.Average < two.Average;
        }

        static public bool operator >(Student one, Student two)
        {
            return one.Average > two.Average;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Student Details");
            sb.AppendLine($"Name: {this.Name}");
            sb.AppendLine($"Average: {this.Average}");
            sb.AppendLine($"Has Completed All Assignments: {this.HasCompletedAllAssignments}");
            sb.AppendLine($"Currently Assigned: {this.Grades.Assignments.Count} Assignments");
            return sb.ToString();
        }

        public int CompareTo(Student other)
        {
            if (other == null) return 1;
            return this.Average.CompareTo(other.Average);
        }
    }
}

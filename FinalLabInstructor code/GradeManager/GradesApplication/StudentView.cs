using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesApplication
{
    class StudentView : View
    {
        private Student _currentStudent;
        public StudentView(Student student)
        {
            this.Banner = $"Currently Editing {student.Name}";
            this._currentStudent = student;
            this.IsSubMenu = true;
            this.AddMenuItem(new MenuItem("1", "Show Student Summary", () => { Console.WriteLine(this._currentStudent.ToString()); }));
            this.AddMenuItem(new MenuItem("2", "Assign Something to Student", this.Assign));
            this.AddMenuItem(new MenuItem("3", "Unassign Something to Student", this.UnAssign));
            this.AddMenuItem(new MenuItem("4", "Show Assignments", this.ShowAssignments));
            this.AddMenuItem(new MenuItem("5", "Grade Assignment", this.GradeAssignment));
            this.AddMenuItem(new MenuItem("6", "Show Students Best Grade", () => { Console.WriteLine(this._currentStudent.TopAssignment()); }));
            this.AddMenuItem(new MenuItem("7", "Show Students Worst Grade", () => { Console.WriteLine(this._currentStudent.WorstAssignment()); }));
        }

        private void Assign()
        {
            Console.WriteLine("Please Enter the name of the assignment: ");
            string name = Console.ReadLine();
            this._currentStudent.Assign(name);
            Console.WriteLine($"{name} was assigned to {this._currentStudent.Name}.");
        }

        private void UnAssign()
        {
            this.ShowAssignments();
            Console.WriteLine("Please Enter the name of the assignment: ");
            string name = Console.ReadLine();
            this._currentStudent.Unassign(name);
            Console.WriteLine($"{name} was removed from {this._currentStudent.Name}.");
        }

        private void ShowAssignments()
        {
            foreach(Assignment ass in this._currentStudent.Assignments)
            {
                Console.WriteLine(ass);
            }
        }

        private void GradeAssignment()
        {
            this.ShowAssignments();
            Console.WriteLine("Please Enter the name of the assignment: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please Enter the grade for the assignment: ");
            string grade = Console.ReadLine();
            this._currentStudent.GradeAssignment(name, double.Parse(grade));
            Console.WriteLine($"{name} is now  {grade}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesApplication
{
    public class ClassroomView : View
    {
        private ClassRoom _classRoom = null;

        public ClassroomView(ClassRoom classRoom)
        {
            this.Banner = $"Currently Editing {classRoom.Name}";
            this._classRoom = classRoom;
            this.IsSubMenu = true;
            this.AddMenuItem(new MenuItem("1", "Show Students", this.ShowStudents));
            this.AddMenuItem(new MenuItem("2", "Add Student", this.AddStudent));
            this.AddMenuItem(new MenuItem("3", "RemoveStudents", this.RemoveStudent));
            this.AddMenuItem(new MenuItem("4", "Student Details Menu", this.RunStudentMenu));
            this.AddMenuItem(new MenuItem("5", "Show Class Average", this.ShowClassAverage));
            this.AddMenuItem(new MenuItem("6", "Show Top Student", this.ShowTopStudent));
            this.AddMenuItem(new MenuItem("7", "Show Worst Student", this.ShowWorstStudent));
            this.AddMenuItem(new MenuItem("8", "Compare Two Students", this.Compare));
        }

        private void ShowStudents()
        {
            foreach(Student student in this._classRoom.Students.Values)
            {
                Console.WriteLine(student);
            }
        }

        private void AddStudent()
        {
            Console.WriteLine("Please Enter the name of the student you wish to add: ");
            string student = Console.ReadLine();
            Student newStudent = this._classRoom.AddStudent(student);
            Console.WriteLine($"{newStudent.Name} was added.");
        }

        private void RemoveStudent()
        {
            this.ShowStudents();
            Console.WriteLine("Please Enter the name of the student you wish to remove: ");
            string student = Console.ReadLine();
            Student oldStudent = this._classRoom.RemoveStudent(student);
            Console.WriteLine($"{oldStudent.Name} was removed.");
        }

        private void RunStudentMenu()
        {
            this.ShowStudents();
            Console.WriteLine("Please Enter the name of the student you wish to see details of: ");
            string student = Console.ReadLine();
            Student selectedStudent = this._classRoom.GetStudent(student);
            StudentView sm = new StudentView(selectedStudent);
            sm.Run();
        }

        private void ShowClassAverage()
        {
            Console.WriteLine(this._classRoom.ClassAverage());
        }
        private void ShowTopStudent()
        {
            Console.WriteLine(this._classRoom.GetTopStudentByAverage());
        }

        private void ShowWorstStudent()
        {
            Console.WriteLine(this._classRoom.GetWorstStudentByAverage());
        }

        private void Compare()
        {
            this.ShowStudents();
            Console.WriteLine("Please Enter the name of the first student: ");
            string name = Console.ReadLine();
            Student first = this._classRoom.GetStudent(name);
            Console.WriteLine("Please Enter the name of the second student: ");
            string name2 = Console.ReadLine();
            Student second = this._classRoom.GetStudent(name2);
            if (first > second)
            {
                Console.WriteLine($"{first.Name} is a better student.");
            }
            else if(first < second)
            {
                Console.WriteLine($"{second.Name} is a better student.");
            }
            else
            {
                Console.WriteLine($"{first.Name} && { second.Name} are equal.");
            }

        }
    }
}

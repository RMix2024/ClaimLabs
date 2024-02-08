using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesApplication
{
    public class ClassRoom
    {
        public Dictionary<string, Student> Students { get; }
        public string Name { get; }

        public int StudentCount
        {
            get
            {
                return this.Students.Count;
            }
        }

        public ClassRoom(string name)
        {
            this.Students = new Dictionary<string, Student>();
            this.Name = name;
        }

        public void AddStudent(Student student)
        {
            this.Students.Add(student.Name, student);
        }

        public Student AddStudent(string student)
        {
            var adding = new Student(student);
            this.Students.Add(student, adding);
            return adding;
        }

        public void RemoveStudent(Student student)
        {
            this.Students.Remove(student.Name);
        }

        public Student RemoveStudent(string student)
        {
            Student oldStudent = this.Students[student];
            this.Students.Remove(student);
            return oldStudent;
        }

        public Student GetStudent(string name)
        {
            return this.Students[name];
        }

        public Student GetTopStudentByAverage()
        {
            return this.Students.Values.ToList().Max();
        }

        public Student GetWorstStudentByAverage()
        {
            return this.Students.Values.ToList().Min();
        }

        public double ClassAverage()
        {
            List<double> grades = new List<double>();
            foreach(Student student in this.Students.Values)
            {
                foreach(Assignment ass in student.Assignments)
                {
                    if (ass.IsComplete)
                    {
                        grades.Add(ass.Grade);
                    }
                }
            }
            if (grades.Count == 0) return 0;
            return grades.Average();
        }
    }
}

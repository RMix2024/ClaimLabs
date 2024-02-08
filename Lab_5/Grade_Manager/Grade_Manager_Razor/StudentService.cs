using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Grade_Manager_Razor.Models;
using Grade_Manager_Razor.Data;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace Grade_Manager_Razor
{
    public class StudentService
    {
        [BindProperty]
        public Assignment assignment { get; set; }

        readonly GradeManagerDbContext _context;

        private readonly AssignmentService _service;

        readonly ILogger _logger;

       

        public StudentService(GradeManagerDbContext context, ILoggerFactory factory, AssignmentService service)
        {
            this._context = context;
            this._service = service;
            _logger = factory.CreateLogger<StudentService>();
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            var studentList = _context.Students;
            foreach (var student in studentList)
            {
                students.Add(student);

            }
            return students;

        }

        public List<Student> GetFilteredStudents(int id)
        {
            List<Student> students = new List<Student>();

            var studentList = _context.Students
                .Where(x => x.ClassRoomId == id);
            foreach (var student in studentList)
            {
                students.Add(student);
            }
            return students;

        }

        public Student AddNewStudent(AddStudentViewModel name)
        {
            var student = name.ToStudent();            
            _context.Add(student);
            _context.SaveChanges();
            return student;
        }

        public Student GetFilteredStudentToDelete(int StudentId)
        {
            return this._context.Students.Where(x => x.StudentId == StudentId).FirstOrDefault();
        }

        public Student GetAStudentById(int id)
        {
            return this._context.Students.Where(x => x.StudentId == id).FirstOrDefault();
        }

        public Student GetBestStudent(int id)
        {
            List<Student> students = new List<Student>();
            students = GetFilteredStudents(id);
            Student theBestStudent = new Student();
            double topStudentAverage = 0;
            foreach(var student in students)
            {
                double studentAverage = _service.AssignmentsAverage(student.StudentId);
                if(studentAverage > topStudentAverage && studentAverage > 1 && studentAverage > topStudentAverage)
                {
                    topStudentAverage = studentAverage;
                    theBestStudent = student;
                }
            }
            return theBestStudent;
        }

        public Student GetWorstStudent(int id)
        {
            List<Student> students = new List<Student>();
            students = GetFilteredStudents(id);
            Student theWorstStudent = students.First();
            double worstStudentAverage = 100;
            foreach (var student in students)
            {
                double studentAverage = _service.AssignmentsAverage(student.StudentId);
                if (studentAverage <= worstStudentAverage && studentAverage > 1 && studentAverage <= worstStudentAverage)
                {
                    worstStudentAverage = studentAverage;
                    theWorstStudent = student;
                }
            }
            return theWorstStudent;
        }

        public Student Compare2Students(int id, int id2)
        {
            double student1 = _service.AssignmentsAverage(id);
            double student2 = _service.AssignmentsAverage(id2);
            if(student1 > student2)
            {
                return GetAStudentById(id);
            }
            else
            {
                return GetAStudentById(id2);
            }

        }



    }
}


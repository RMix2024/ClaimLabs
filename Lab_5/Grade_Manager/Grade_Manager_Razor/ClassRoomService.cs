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
    public class ClassRoomService
    {
        [BindProperty]
        public Student student { get; set; }

        private readonly StudentService _service;

        private readonly AssignmentService _service2;

        readonly GradeManagerDbContext _context;

        readonly ILogger _logger;

        public ClassRoomService(GradeManagerDbContext context, ILoggerFactory factory, StudentService service, AssignmentService service2)
        {
            this._context = context;
            _service = service;
            _service2 = service2;
            _logger = factory.CreateLogger<ClassRoomService>();
        }

        public List<ClassRoom> GetAllClassRooms()
        {
            var classroomList = _context.ClassRooms.ToList();         
            return classroomList;
        }

        public void AddNewClassRoom(AddClassRoomViewModel name)
        {
            var classRoom = name.ToClassRoom();
            _context.Add(classRoom);
            _context.SaveChanges();            
        }

        public ClassRoom GetFilteredClassRooms(int id)
        {
            return this._context.ClassRooms.Where(x => x.ClassRoomId == id).FirstOrDefault();
                
        }

        public double ClassRoomAverage(int id)
        {
            List<Student> students = new List<Student>();
            students = _service.GetFilteredStudents(id);
            double studentAveragesTotal = 0;
            foreach(var student in students)
            {
                studentAveragesTotal = studentAveragesTotal + _service2.AssignmentsAverage(student.StudentId);
            }
            return studentAveragesTotal / students.Count;
            
        }

        

       

    }
}

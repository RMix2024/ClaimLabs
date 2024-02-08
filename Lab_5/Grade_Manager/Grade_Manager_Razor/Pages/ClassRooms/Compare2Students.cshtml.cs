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
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Grade_Manager_Razor.Pages.ClassRooms
{
    public class Compare2StudentsModel : PageModel
    {
        [BindProperty]
        public string studentId1 { get; set; }

        [BindProperty]
        public string studentId2 { get; set; }

        [BindProperty]
        public Student student3 { get; set; }

        [BindProperty]
        public int studentid { get; set; }


        public List<SelectListItem> DropDownList { get; set; } = new List<SelectListItem>();

        [BindProperty]
        public List<Student> Students { get; set; }

        private readonly StudentService _service;

        private readonly AssignmentService _service2;

        private readonly GradeManagerDbContext _context;

        private readonly ILogger<Compare2StudentsModel> _logger;

        public Compare2StudentsModel(ILogger<Compare2StudentsModel> logger, GradeManagerDbContext context, StudentService service, AssignmentService service2)
        {
            _logger = logger;
            _context = context;
            _service = service;
            _service2 = service2;
        }
        public void OnGet(int id)
        {
            Students = _service.GetFilteredStudents(id);
            foreach(var student in Students)
            {
               DropDownList.Add(new SelectListItem { Value = student.StudentId.ToString(), Text=student.Name });
            }
            
        }

        public IActionResult OnPost()
        {
            student3 = _service.Compare2Students(int.Parse(studentId1), int.Parse(studentId2));
            return RedirectToPage("/ClassRooms/ComparedStudentsWinner", new { StudentId = student3.StudentId });
        }
    }
}

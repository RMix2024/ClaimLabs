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

namespace Grade_Manager_Razor.Pages.Students
{
    public class ShowWorstGradeModel : PageModel
    {
        [BindProperty]
        public Student student { get; set; }

        [BindProperty]
        public int studentid { get; set; }

        [BindProperty]
        public List<Student> Students { get; set; }

        [BindProperty]
        public Assignment assignment { get; set; }

        private readonly StudentService _service;

        private readonly AssignmentService _service2;


        public GradeManagerDbContext _context { get; set; }

        private readonly ILogger<ShowWorstGradeModel> _logger;

        public ShowWorstGradeModel(StudentService service, ILogger<ShowWorstGradeModel> logger, GradeManagerDbContext context, AssignmentService service2)
        {
            _service = service;
            _service2 = service2;
            _logger = logger;
            _context = context;
        }
        public void OnGet(int StudentId)
        {
            assignment = _service2.GetWorstAssignment(StudentId);
            student = _service.GetAStudentById(StudentId);
        }

        public void OnPost()
        {

        }
    }
}

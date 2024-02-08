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
    public class ShowBestGradeModel : PageModel
    {
        [BindProperty]
        public Student student { get; set; }

        [BindProperty]
        public Assignment assignment { get; set; }

        [BindProperty]
        public int studentid { get; set; }

        [BindProperty]
        public List<Student> Students { get; set; }

        private readonly StudentService _service;

        private readonly AssignmentService _service2;

        private readonly ILogger<ShowBestGradeModel> _logger;

        public GradeManagerDbContext _context { get; set; }

        public ShowBestGradeModel(StudentService service, ILogger<ShowBestGradeModel> logger, GradeManagerDbContext context, AssignmentService service2)
        {
            _service = service;
            _service2 = service2;
            _logger = logger;
            _context = context;
        }
        public void OnGet(int StudentId)
        {
            assignment = _service2.GetBestAssignment(StudentId);
            student = _service.GetAStudentById(StudentId);
        }

        public void OnPost()
        {

        }
    }
}

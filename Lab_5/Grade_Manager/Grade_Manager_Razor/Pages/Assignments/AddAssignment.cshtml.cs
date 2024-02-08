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

namespace Grade_Manager_Razor.Pages.Assignments
{
    public class AddAssignmentModel : PageModel
    {
        [BindProperty]
        public Assignment Assignments { get; set; }

        [BindProperty]
        public AddAssignmentViewModel Input { get; set; }

        [BindProperty]
        public Assignment Assignment { get; set; }

        [BindProperty]
        public int studentid { get; set; }

        [BindProperty]
        public Student student { get; set; }

        [BindProperty]
        public Student Students { get; set; }

        private readonly AssignmentService _service;

        private readonly StudentService _service2;

        private readonly ILogger<AddAssignmentModel> _logger;

        public GradeManagerDbContext _context;

        public AddAssignmentModel(ILogger<AddAssignmentModel> logger, AssignmentService service, GradeManagerDbContext context, StudentService service2)
        {
            _logger = logger;
            _service = service;
            _service2 = service2;
            _context = context;
        }
        public void OnGet(int StudentId)
        {
            Input = new AddAssignmentViewModel();
            studentid = StudentId;
            student = _service2.GetAStudentById(StudentId);
        }

        public IActionResult OnPost()
        {
            Input.StudentId = studentid;
            _service.AddNewAssignment(Input);
            //return RedirectToPage("../Index");
            return RedirectToPage("/Students/StudentDetailsMenu", new { StudentId = Assignment.StudentId });
        }

     
    }
}

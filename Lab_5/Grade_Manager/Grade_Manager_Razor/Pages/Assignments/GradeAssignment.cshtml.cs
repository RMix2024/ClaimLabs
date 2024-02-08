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
    public class GradeAssignmentModel : PageModel
    {
        
        

        [BindProperty]
        public Assignment Assignment { get; set; }
        public object Student { get; private set; }

        private ClassRoom classRoom { get; set; }

        private readonly AssignmentService _service;

        private readonly StudentService _service2;

        private readonly ClassRoomService _service3;
        public GradeManagerDbContext _context { get; set; }

        private readonly ILogger<GradeAssignmentModel> _logger;

        public GradeAssignmentModel(ILogger<GradeAssignmentModel> logger, AssignmentService service, GradeManagerDbContext context,
            StudentService service2, ClassRoomService service3)
        {
            _logger = logger;
            _service = service;
            _service2 = service2;
            _service3 = service3;
            _context = context;
        }



        public IActionResult OnGet(int? AssignmentId)
        {
            Assignment = _context.Assignments.Find(AssignmentId);
            if (AssignmentId == null)
            {             
                return NotFound();
            }            

            if (Assignment == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int AssignmentId)
        {
            var assignmentToUpdate = await _context.Assignments.FindAsync(AssignmentId);
            if (assignmentToUpdate == null)
            {
                return NotFound();
            }
            if (await TryUpdateModelAsync<Assignment>(
                assignmentToUpdate,
                "Assignment",
                a=>a.Grade, 
                a=>a.IsComplete,
                a=>a.AssignmentId,
                a=>a.Name,
                a=>a.StudentId
                ))
            {
                await _context.SaveChangesAsync();
                return RedirectToPage("/Students/StudentDetailsMenu", new { StudentId = Assignment.StudentId });
            }

            return Page();          
        
        }
    }
}


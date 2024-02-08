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

namespace Grade_Manager_Razor.Pages.Assignments
{
    public class DeleteAssignmentModel : PageModel
    {
        [BindProperty]
        public Assignment assignment { get; set; }

        [BindProperty]
        public int assignmentid { get; set; }

        [BindProperty]
        public List<Assignment> Assignments { get; set; }

        private readonly AssignmentService _service;

        private readonly ILogger<DeleteAssignmentModel> _logger;

        public GradeManagerDbContext _context { get; set; }



        public DeleteAssignmentModel(AssignmentService service, ILogger<DeleteAssignmentModel> logger, GradeManagerDbContext context)
        {
            _service = service;
            _logger = logger;
            _context = context;
        }




        public void OnGet(int AssignmentId)
        {
            assignment = _service.GetFilteredAssignmentToDelete(AssignmentId);
        }

        public async Task<IActionResult> OnPostDelete(int AssignmentId)
        {
            Console.WriteLine(AssignmentId);
            var assignment = await _context.Assignments.FindAsync(AssignmentId);
            if (assignment == null)
            {
                return NotFound();
            }
            _context.Remove(assignment);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Students/StudentDetailsMenu", new { StudentId = assignment.StudentId });
        }
    }
}

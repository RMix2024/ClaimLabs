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
    public class DeleteStudentModel : PageModel
    {
            [BindProperty]
            public Student student { get; set; }

            [BindProperty]
            public int studentid { get; set; }

            [BindProperty]
            public List<Student> Students { get; set; }

            private readonly StudentService _service;

            private readonly ILogger<DeleteStudentModel> _logger;

            public GradeManagerDbContext _context { get; set; }



            public DeleteStudentModel(StudentService service, ILogger<DeleteStudentModel> logger, GradeManagerDbContext context)
            {
                _service = service;
                _logger = logger;
                _context = context;
            }




            public void OnGet(int StudentId)
            {
                student = _service.GetFilteredStudentToDelete(StudentId);
            }

            public async Task<IActionResult> OnPostDelete(int StudentId)
            {
                Console.WriteLine(StudentId);
                var student = await _context.Students.FindAsync(StudentId);
                if (student == null)
                {
                    return NotFound();
                }
                _context.Remove(student);
                await _context.SaveChangesAsync();

            return RedirectToPage("/ClassRooms/ClassRoomDetailsMenu", new { id = student.ClassRoomId });
        }
    }
}

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
    public class ComparedStudentsWinnerModel : PageModel
    {
        [BindProperty]
        public Student student { get; set; }

        [BindProperty]
        public ClassRoom classRoom { get; set; }
        
        public int classroomid { get; set; }

        private readonly GradeManagerDbContext _context;

        private readonly StudentService _service;

        private readonly ILogger<ComparedStudentsWinnerModel> _logger;

        public ComparedStudentsWinnerModel(ILogger<ComparedStudentsWinnerModel> logger, GradeManagerDbContext context, StudentService service)
        {
            _logger = logger;
            _context = context;
            _service = service;
           
        }

        public void OnGet(int StudentId)
        {
            student = _service.GetAStudentById(StudentId);
        }
    }
}

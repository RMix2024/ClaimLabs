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

namespace Grade_Manager_Razor.Pages.ClassRooms
{
    public class ShowWorstStudentModel : PageModel
    {

        [BindProperty]
        public Student student { get; set; }

        [BindProperty]
        public ClassRoom classRoom { get; set; }

        private readonly ClassRoomService _service;

        private readonly StudentService _service2;

        private readonly GradeManagerDbContext _context;

        private readonly ILogger<ShowWorstStudentModel> _logger;

        public ShowWorstStudentModel(ILogger<ShowWorstStudentModel> logger, ClassRoomService service, StudentService service2, GradeManagerDbContext context)
        {
            _logger = logger;
            _context = context;
            _service = service;
            _service2 = service2;
        }
        public void OnGet(int id)
        {
            classRoom = _service.GetFilteredClassRooms(id);
            student = _service2.GetWorstStudent(id);
        }

        public void OnPost()
        {

        }
    }
}

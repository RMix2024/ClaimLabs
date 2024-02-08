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
    public class ShowClassAverageModel : PageModel
    {
        [BindProperty]
        public ClassRoom classRoom { get; set; }

        [BindProperty]
        public Student student { get; set; }

        [BindProperty]
        public int studentid { get; set; }

        public double classroomsAverage { get; set; }

        [BindProperty]
        public List<ClassRoom> classRooms { get; set; }

        private readonly ClassRoomService _service;

        private readonly StudentService _service2;

        private readonly ILogger<ShowClassAverageModel> _logger;

        public GradeManagerDbContext _context { get; set; }

        public ShowClassAverageModel(ClassRoomService service, ILogger<ShowClassAverageModel> logger, GradeManagerDbContext context, StudentService service2)
        {
            _service = service;
            _service2 = service2;
            _logger = logger;
            _context = context;
        }
        public void OnGet(int id)
        {
            classRoom = _service.GetFilteredClassRooms(id);
            classroomsAverage = _service.ClassRoomAverage(id);
        }

        public void OnPost()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Grade_Manager_Razor.Models;
using Grade_Manager_Razor.Data;

namespace Grade_Manager_Razor.Pages.ClassRooms
{
    public class DeleteClassRoomModel : PageModel
    {
        [BindProperty]
        public ClassRoom classRoom { get; set; }

        [BindProperty]
        public int classroomid { get; set; }

        [BindProperty]
        public List<ClassRoom> ClassRooms { get; set; }

        private readonly ClassRoomService _service;

        private readonly ILogger<DeleteClassRoomModel> _logger;

        public GradeManagerDbContext _context { get; set; }
       

       
        public DeleteClassRoomModel(ClassRoomService service,ILogger<DeleteClassRoomModel> logger, GradeManagerDbContext context)
        {
            _service = service;
            _logger = logger;
            _context = context;
        }

       


        public void OnGet(int id)
        {
            classRoom = _service.GetFilteredClassRooms(id);
            
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            Console.WriteLine(id);
            var classroom = await _context.ClassRooms.FindAsync(id);
            if (classroom == null)
            {
                return NotFound();
            }
            _context.Remove(classroom);
            await _context.SaveChangesAsync();
            return RedirectToPage("../Index");
        }




    }
}



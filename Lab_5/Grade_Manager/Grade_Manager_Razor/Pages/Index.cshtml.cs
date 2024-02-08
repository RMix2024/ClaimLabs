using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grade_Manager_Razor.Models;
using Microsoft.Extensions.DependencyInjection;
using Grade_Manager_Razor.Data;



namespace Grade_Manager_Razor.Pages
{
    public class IndexModel : PageModel

    {
        private readonly ClassRoomService _service;
        public GradeManagerDbContext _context { get; set; }

        [BindProperty]
        public List<ClassRoom> ClassRooms { get; private set; }

        

        public IndexModel(ClassRoomService service, GradeManagerDbContext context)
        {
            _service = service;
            _context = context;
        }

        public void OnGet()
        {
            ClassRooms = _service.GetAllClassRooms();
        }



    }
}

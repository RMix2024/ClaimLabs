using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Grade_Manager_Razor.Models;
using Grade_Manager_Razor.Data;
using Microsoft.Extensions.DependencyInjection;


namespace Grade_Manager_Razor.Pages.ClassRooms
{
    public class ClassRoomDetailsMenuModel : PageModel
    {
        [BindProperty]
        public ClassRoom classRoom { get; set; }

        private readonly ClassRoomService _service2;
        public GradeManagerDbContext _context { get; set; }

        private readonly StudentService _service;

        [BindProperty]
        public List<Student> Students { get; private set; }

        public ClassRoomDetailsMenuModel(StudentService service, ClassRoomService service2)
        {
            _service = service;
            _service2 = service2;
        }

        public void OnGet(int id)
        {
            Students = _service.GetFilteredStudents(id);
            classRoom = _service2.GetFilteredClassRooms(id);
        }

        public void OnPost()
        {

        }

    }
}

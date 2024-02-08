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


namespace Grade_Manager_Razor.Pages.Students
{
    public class AddStudentModel : PageModel
    {
        [BindProperty]
        public Student Students { get; set; }

        [BindProperty]
        public AddStudentViewModel Input { get; set; }

        [BindProperty]
        public int classroomid { get; set; }

        [BindProperty]
        public ClassRoom ClassRooms { get; set; }

        private readonly StudentService _service;

        private readonly ILogger<AddStudentModel> _logger;

        public AddStudentModel(ILogger<AddStudentModel> logger, StudentService service)
        {
            _logger = logger;
            _service = service;
        }
        public void OnGet(int id)
        {
            Input = new AddStudentViewModel();
            classroomid = id;
           
        }
     

        public IActionResult OnPost()
        {
            Input.ClassRoomId = classroomid;
            _service.AddNewStudent(Input);

            //return RedirectToPage("StudentDetailsMenu", new { Input.StudentId });
            return RedirectToPage("/ClassRooms/ClassRoomDetailsMenu", new { id = classroomid });


        }

    }
}

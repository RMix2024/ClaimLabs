using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Grade_Manager_Razor.Models;
using System.Diagnostics;

namespace Grade_Manager_Razor.Pages.ClassRooms
{
    public class AddClassRoomModel : PageModel
    {
        [BindProperty]
        public AddClassRoomViewModel Input { get; set; }

        private readonly ClassRoomService _service;

        private readonly ILogger<AddClassRoomModel> _logger;

        public AddClassRoomModel(ILogger<AddClassRoomModel> logger, ClassRoomService service)
        {
            _logger = logger;
            _service = service;
        }
        public void OnGet()
        {
            Input = new AddClassRoomViewModel();
        }
        public IActionResult OnPost()
        {
            _service.AddNewClassRoom(Input);
            return RedirectToPage("../Index");

        }
    }
}

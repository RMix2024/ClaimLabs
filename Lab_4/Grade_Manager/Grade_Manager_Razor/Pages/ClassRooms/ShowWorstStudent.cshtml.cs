using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Grade_Manager_Razor.Pages.ClassRooms
{
    public class ShowWorstStudentModel : PageModel
    {
        private readonly ILogger<ShowWorstStudentModel> _logger;

        public ShowWorstStudentModel(ILogger<ShowWorstStudentModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
}

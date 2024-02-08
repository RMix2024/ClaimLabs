using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Grade_Manager_Razor.Pages.Students
{
    public class AddStudentModel : PageModel
    {
        [BindProperty]
        public Student Students { get; set; }

        private readonly ILogger<AddStudentModel> _logger;

        public AddStudentModel(ILogger<AddStudentModel> logger)
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

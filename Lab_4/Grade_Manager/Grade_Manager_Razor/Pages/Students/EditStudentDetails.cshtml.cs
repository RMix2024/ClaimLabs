using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Grade_Manager_Razor.Pages.Students
{
    public class EditStudentDetailsModel : PageModel
    {
        private readonly ILogger<EditStudentDetailsModel> _logger;

        public EditStudentDetailsModel(ILogger<EditStudentDetailsModel> logger)
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

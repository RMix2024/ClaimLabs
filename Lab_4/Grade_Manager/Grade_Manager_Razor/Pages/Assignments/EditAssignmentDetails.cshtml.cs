using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Grade_Manager_Razor.Pages.Assignments
{
    public class EditAssignmentDetailsModel : PageModel
    {
        private readonly ILogger<EditAssignmentDetailsModel> _logger;

        public EditAssignmentDetailsModel(ILogger<EditAssignmentDetailsModel> logger)
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

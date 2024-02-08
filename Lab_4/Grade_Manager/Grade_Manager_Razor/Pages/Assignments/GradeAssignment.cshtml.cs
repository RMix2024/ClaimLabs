using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Grade_Manager_Razor.Pages.Assignments
{
    public class GradeAssignmentModel : PageModel
    {
        private readonly ILogger<GradeAssignmentModel> _logger;

        public GradeAssignmentModel(ILogger<GradeAssignmentModel> logger)
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

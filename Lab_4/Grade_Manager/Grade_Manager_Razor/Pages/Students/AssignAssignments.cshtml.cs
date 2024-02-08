using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Grade_Manager_Razor.Pages.Students
{
    public class AssignAssignmentsModel : PageModel
    {
        private readonly ILogger<AssignAssignmentsModel> _logger;

        public AssignAssignmentsModel(ILogger<AssignAssignmentsModel> logger)
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

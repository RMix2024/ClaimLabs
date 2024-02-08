using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


namespace Grade_Manager_Razor.Pages.Assignments
{
    public class AddAssignmentModel : PageModel
    {
        private readonly ILogger<AddAssignmentModel> _logger;

        public AddAssignmentModel(ILogger<AddAssignmentModel> logger)
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

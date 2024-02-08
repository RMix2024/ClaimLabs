using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Grade_Manager_Razor.Pages
{
    public class StudentsModel : PageModel
    {
        
        private readonly ILogger<StudentsModel> _logger;

        public StudentsModel(ILogger<StudentsModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}

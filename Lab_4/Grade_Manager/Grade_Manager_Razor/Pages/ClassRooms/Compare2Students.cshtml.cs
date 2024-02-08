using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Grade_Manager_Razor.Pages.ClassRooms
{
    public class Compare2StudentsModel : PageModel
    {
        private readonly ILogger<Compare2StudentsModel> _logger;

        public Compare2StudentsModel(ILogger<Compare2StudentsModel> logger)
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

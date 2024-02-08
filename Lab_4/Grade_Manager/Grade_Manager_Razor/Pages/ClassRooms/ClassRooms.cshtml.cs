using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Grade_Manager_Razor.Pages
{
    public class ClassRoomsModel : PageModel
    {
        private readonly ILogger<ClassRoomsModel> _logger;

        public ClassRoomsModel(ILogger<ClassRoomsModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Grade_Manager_Razor.Pages.Students
{
    public class ShowAllStudentsModel : PageModel
    {
        public Dictionary<string, Student> StudentDictionary { get; set; }

        private readonly ILogger<ShowAllStudentsModel> _logger;

        public ShowAllStudentsModel(ILogger<ShowAllStudentsModel> logger)
        {
            _logger = logger;
            this.StudentDictionary = new Dictionary<string, Student>();
            this.StudentDictionary.Add("Student1", new Student() { Name = "Bob" });
            this.StudentDictionary.Add("Student2", new Student() { Name = "Joe" });
            this.StudentDictionary.Add("Student3", new Student() { Name = "Lars" });

        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
        }
    }
}

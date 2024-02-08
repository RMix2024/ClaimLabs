using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


namespace Grade_Manager_Razor.Pages.Assignments
{
    public class ShowAllAssignmentsModel : PageModel
    {
        public Dictionary<string, Assignment> AssignmentsDictionary { get; set; }

       

        private readonly ILogger<ShowAllAssignmentsModel> _logger;

        public ShowAllAssignmentsModel(ILogger<ShowAllAssignmentsModel> logger)
        {
            _logger = logger;
            this.AssignmentsDictionary = new Dictionary<string, Assignment>();
            this.AssignmentsDictionary.Add("Assignment1", new Assignment() { Name = "Grade Manager", IsComplete = true });
            this.AssignmentsDictionary.Add("Assignment2", new Assignment() { Name = "Grade Manger OOP", IsComplete = true });
            this.AssignmentsDictionary.Add("Assignment3", new Assignment() { Name = "Grade Manger Razor Edition", IsComplete = false });
        }
        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
}

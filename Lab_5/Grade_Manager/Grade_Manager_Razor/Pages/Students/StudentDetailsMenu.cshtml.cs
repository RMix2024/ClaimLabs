using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Grade_Manager_Razor.Models;
using Grade_Manager_Razor.Data;
using Microsoft.Extensions.DependencyInjection;


namespace Grade_Manager_Razor.Pages.Students
{
    public class StudentDetailsMenuModel : PageModel
    {
        [BindProperty]
        public Student student { get; set; }

        public double asssignmentsAverage;

        private readonly AssignmentService _service;

        private readonly StudentService _service2;

        public GradeManagerDbContext _context { get; set; }

        public List<Assignment> Assignments { get; private set; }

       

        public StudentDetailsMenuModel(AssignmentService service, GradeManagerDbContext context, StudentService service2)
        {
            _context = context;
            _service = service;
            _service2 = service2;
        }

        public void OnGet(int StudentId)
        {
            Assignments = _service.GetFilteredAssignments(StudentId);
            student = _service2.GetAStudentById(StudentId);
            asssignmentsAverage = _service.AssignmentsAverage(StudentId);
            
        }  
        
        public void OnPost()
        {

        }
    }
}

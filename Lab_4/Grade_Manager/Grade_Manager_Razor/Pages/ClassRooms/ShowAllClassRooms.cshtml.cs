using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Grade_Manager_Razor.Pages.ClassRooms
{
    public class ShowAllClassRoomsModel : PageModel
    {
        public Dictionary<string, ClassRoom> ClassRoomDictionary { get; set; }

        private readonly ILogger<ShowAllClassRoomsModel> _logger;

        public ShowAllClassRoomsModel(ILogger<ShowAllClassRoomsModel> logger)
        {
            _logger = logger;

            this.ClassRoomDictionary = new Dictionary<string, ClassRoom>();
            this.ClassRoomDictionary.Add("ClassRoom1", new ClassRoom() { Name = "C#" });
            this.ClassRoomDictionary.Add("ClassRoom2", new ClassRoom() { Name = "ASP.Net" });
            this.ClassRoomDictionary.Add("ClassRoom3", new ClassRoom() { Name = "Entity FrameWork" });

        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
        }
        
    }
}

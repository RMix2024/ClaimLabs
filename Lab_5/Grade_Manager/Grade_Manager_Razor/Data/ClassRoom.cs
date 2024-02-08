using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Grade_Manager_Razor
{
    public class ClassRoom
    {
        [Key]
        public int ClassRoomId { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();
        
       
      
    }
}

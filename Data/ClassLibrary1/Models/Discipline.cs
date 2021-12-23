using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Discipline
    {
        [Required]        
        public Guid Id { get; set; }

        [Required]
        public string? Title { get; set; }

        public List<Register>? Registers { get; set; }
        public List<AttendanceLog>? AttendanceLog { get; set; }
    }
}

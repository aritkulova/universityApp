using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Group
    {
        [Required]        
        public Guid Id { get; set; }

        public string? Title { get; set; }

        public string? Speciality { get; set; }

        public Stream? Stream { get; set; }

        public List<Register> Registers { get; set; } = new List<Register>();
    }
}

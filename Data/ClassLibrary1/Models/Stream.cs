using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Stream
    {
        [Required]       
        public Guid Id { get; set; }

        public string? Title { get; set; }

        public string? Faculty { get; set; }
    }
}

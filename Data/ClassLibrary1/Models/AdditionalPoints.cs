using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class AdditionalPoints
    {
        public Student? Student { get; set; }

        public DateTime Date { get; set; }

        [Range(0, 40)]
        public int Points { get; set; }
    }
}

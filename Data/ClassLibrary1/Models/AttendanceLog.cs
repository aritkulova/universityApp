using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class AttendanceLog
    {
        public Discipline? Discipline { get; set; }

        public DateTime Date { get ;  set ; }

        public Student? Student { get; set; }

        public bool Presence { get; set; }
    }
}

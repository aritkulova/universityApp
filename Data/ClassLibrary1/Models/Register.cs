using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Register
    {
        [Required]       
        public Guid Id { get; set; }

        [Range(1, 2, ErrorMessage = "Семестр может быть только 1 или 2")]
        public int Term { get; set; } 

        [StringLength(9, MinimumLength = 8)]
        [RegularExpression(@"\d{4}(\s|-|/|\\)\d{4}")]
        public string? StudyYears { get; set; }

        private Employee? teacher;
        public Employee? Teacher {

            get { return teacher; }
            set 
            {
                if (value == null) teacher = null;
                if (value?.Position == "Преподаватель")
                {
                    teacher = value;
                }
                else
                {
                    throw new Exception("Недопустимая для преподавания позиция");                    
                }                
            } 
        }

        public Discipline? Discipline { get; set; }

        public Group? Group { get; set; }

        public List<FinalGrade>? FinalGrades { get; set; }
    }
}

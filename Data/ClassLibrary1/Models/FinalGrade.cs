using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class FinalGrade
    {
        [Required]
        //[Range(0, System.Double.PositiveInfinity)]
        public Guid Id { get; set; }

        [Range(1, 100, ErrorMessage = "Недопустимое значение оценки")]
        public int Mark { get;set;  }

        private string markLetter = "";
        public string MarkLetter
        {
            get 
            {
                if (markLetter == "")
                {
                    if ((0<=Mark) && (Mark <= 34)) markLetter = "F";
                    else if (Mark <= 59) markLetter = "FX";
                    else if (Mark <= 68) markLetter = "E";
                    else if (Mark <= 74) markLetter = "D";
                    else if (Mark <= 89) markLetter = "C";
                    else if (Mark <= 95) markLetter = "B";
                    else markLetter = "A";
                }

                return markLetter;
            }    
        }

        public DateTime Date { get ; set ; }

        public Student? Student { get; set; }

        public Register? Register { get; set; }
    }
}

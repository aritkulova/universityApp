using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Employee
    {
        [Required]
        public Guid Id { get; set; }
       
        [StringLength(20, MinimumLength = 2)]
        public string? FirstName { get; set; }

        [StringLength(20, MinimumLength = 2)]
        public string? SecondName { get; set; }

        //[StringLength(8, MinimumLength = 5)]
        public string? Position { get; set; }

        [RegularExpression("380\\d{9}", ErrorMessage = "Неправильный номер телефона")]
        public string? Phone { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [RegularExpression(@"\d{1,2}.\d{1,2}.\d{4}")]
        //public string? Birthday { get; set; }
        public DateTime Birthday { get; set; }
    }
}

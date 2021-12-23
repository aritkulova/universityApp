using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Entities.Models
{
    public class StudentAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null) return false;

            Student s = (Student)value;
            bool res = true;

            if (!((s.FormOfEducation == "бюджет") || (s.FormOfEducation == "контракт")))
            {
                ErrorMessage += "Форма обучения должна быть 'бюджет' или 'контракт';\n";
                res = false;
            }

            string pattern = @"^([A-Z]|[А-Я])";

            Match m;
            if (s.FirstName != null) {
                m = Regex.Match(s.FirstName, pattern);
                if (!m.Success)
                {
                    ErrorMessage += "Имя должно начинаться с буквы верхнего регистра;\n ";
                    res = false;
                }
            }

            if (s.SecondName != null)
            {
                m = Regex.Match(s.SecondName, pattern);
                if (!m.Success)
                {
                    ErrorMessage += "Фамилия должна начинаться с буквы верхнего регистра; ";
                    res = false;
                }
            }

            return res;
        }
    }

    [Student]
    public class Student
    {
        [Required]        
        //public int Id { get; set; }
        public Guid Id { get; set; }

        [StringLength(20, MinimumLength = 2)]
        public string? FirstName { get; set; }

        [StringLength(20, MinimumLength = 2)]
        public string? SecondName { get; set; }
               
        public string? FormOfEducation { get; set; }

        [RegularExpression("380\\d{9}")] 
        public string? Phone { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [RegularExpression(@"\d{1,2}.\d{1,2}.\d{4}")] 
        public string? Birthday { get; set; }
        //public DateTime Birthday { get; set; }

        public List<FinalGrade>? FinalGrades { get; set; }
        public List<AttendanceLog>? StudentAttendanceLogs { get; set; }
        public List<AdditionalPoints>? StudentAdditionalPoints { get; set; }
        public List<Rank>? StudentRanks { get; set; }

    }
}

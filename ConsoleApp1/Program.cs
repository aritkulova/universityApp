using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace ConsoleApp1
{    
    class Program
    {
        static void Main(string[] args)
        {
           Student s = new Student {FirstName="Аня", SecondName = "Hound", FormOfEducation = "бюджет" ,
               Phone ="380632967501", Email = "aaaa@gmail.com" , Birthday = "20.11.2000" }; //new DateTime(200,11,20)


            var cont = new ValidationContext(s);
            var res = new List<ValidationResult>();
            if (!Validator.TryValidateObject(s, cont, res, true))
            {
                foreach (var temp in res)
                {
                    Console.WriteLine(temp.ErrorMessage);
                }
            }

            Register reg = new Register { StudyYears = "2019 2020", Term = 1 };

            cont = new ValidationContext(reg);
            res = new List<ValidationResult>();
            if (!Validator.TryValidateObject(reg, cont, res, true))
            {
                foreach (var temp in res)
                {
                    Console.WriteLine(temp.ErrorMessage);
                }
            }

            FinalGrade fg=new() { Mark=98, Date = new DateTime(2021, 12,14), Student = s};

            Console.WriteLine("Student: " + s.Id +" "+ s.FirstName + " " + s.SecondName + " " + s.FormOfEducation);

            Console.WriteLine("Final grade: " + fg.Id + " mark:" + fg.Mark  + " mark: " + fg.MarkLetter + " " + fg.Date);

            Console.ReadLine();
        }
    }
}

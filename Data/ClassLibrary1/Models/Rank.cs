using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Rank
    {
        public Student? Student { get; set; }

        public DateTime Date { get; set; }

        [Range(0, 100, ErrorMessage = "Рейтинг должен быть от 0 до 100")]
        public float Rate { get; set; }

        public string? AdditionalInfo { get; set; }

        //public void WhatIfCatchUp();

        //public void WhoGetsScolarship();
    }
}

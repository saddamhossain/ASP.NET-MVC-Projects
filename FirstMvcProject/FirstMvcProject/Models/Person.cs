using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstMvcProject.Models
{
    public class Person
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string First { get; set; }

        [Required]
        [StringLength(30)]
        public string Last { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
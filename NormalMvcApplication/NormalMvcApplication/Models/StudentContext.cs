using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NormalMvcApplication.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("ApplicationServices")
        {
    
        }

        public DbSet<Student> Students { get; set; } // here Students ta ki kaj kortece r keno ayta dilam 

    }
}
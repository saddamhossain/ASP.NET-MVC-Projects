using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FirstMvcProject.Models
{
    public class PersonContext : DbContext
    {
         public PersonContext(): base("ApplicationServices")
         {
        
         }
        public DbSet<Person> People { get; set; }
    }
}
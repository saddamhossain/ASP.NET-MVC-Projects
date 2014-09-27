using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ScaffoldingDemo.Models
{
    public class StoreContext : DbContext
    {
        public  StoreContext() : base("AppService")
        { 
        
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScaffoldingDemo.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public decimal? UnitPrice { get; set; }
        public int UnitInStock { get; set; }

        public virtual Category Category { get; set; }
    }
}
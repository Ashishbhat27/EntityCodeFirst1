using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EntityCodeFirst.Models
{
    public class NorthWindContext : DbContext //this context class is going to communicate with the connection string which we defined in the webconfig file.
    {
        public NorthWindContext()
            : base("name=NorthWindConnection")
        {

        }
        public DbSet<Category> CategoriesTable { get; set; }
        public DbSet<Product> ProductsTable { get; set; }
    }
}
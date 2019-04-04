using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class DbProductsContext : DbContext
    {
        public DbProductsContext() : base("name=DbProductsContext")
        {

        }
        public DbSet<Product> product { get; set; }
        public DbSet<Category> category { get; set; }
    }
}

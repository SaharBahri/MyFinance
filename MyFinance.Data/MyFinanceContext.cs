using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data
{
    public class MyFinanceContext : DbContext
    {
        public MyFinanceContext(DbSet<Category> categories, DbSet<Product> products, DbSet<Provider> providers)
        {
            Categories = categories;
            Products = products;
            Providers = providers;
        }

        
        public MyFinanceContext() : base("name=MyFinanceDatabase")
        {
        }

        public DbSet<Category> Categories { get; set; } 
        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }
    }
}

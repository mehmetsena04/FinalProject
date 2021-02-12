

using Entities.concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntitiyFrameWork
{// Context:Db tabloları ile proje classlarını bağlamak
    public class NortWindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqlLocalDB;Database=Northwind;Trusted_Connection=true");
        }

  

        public DbSet<Product> Products { get; set; }

        public DbSet<Category>Categories { get; set; }
        public DbSet<Costumer> Costumers{ get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}

using ShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ShopDAL.Migrations.Configuration;

namespace ShopDAL
{
    public class MyDBContext: DbContext
    {
        public MyDBContext() : base(@"Data Source=.\SQLSERVER;Initial Catalog=InetMag;Integrated Security=True")
        {
            Database.SetInitializer<MyDBContext>(new MyContextInitializer());
        }

        public DbSet<Tovar> Tovars { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(x => x.Tovars)
                .WithRequired(x => x.Category)
                .HasForeignKey(x => x.CategoryId);
        }

    }
}

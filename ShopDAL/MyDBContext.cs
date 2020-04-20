using ShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL
{
    public class MyDBContext: DbContext
    {
        public MyDBContext() : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=ALevel_Shop;Integrated Security=True")
        {
        }

        public DbSet<Tovar> Tovars { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

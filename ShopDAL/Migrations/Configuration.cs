namespace ShopDAL.Migrations
{
    using ShopDAL.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShopDAL.MyDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "ShopDAL.MyDBContext";
        }
        public class MyContextInitializer : DropCreateDatabaseAlways<MyDBContext>
        {
            protected override void Seed(MyDBContext context)
            {
                //  This method will be called after migrating to the latest version.

                //  You can use the DbSet<T>.AddOrUpdate() helper extension method
                //  to avoid creating duplicate seed data.

                context.Categories.Add(new Category { Name = "a1111111111" });
                context.Categories.Add(new Category { Name = "b2222222222" });
                context.Categories.Add(new Category { Name = "c3333333333" });

                context.SaveChanges();

                context.Tovars.Add(new Tovar
                {
                    Name = "ashdjshahkjdksjf",
                    Price = 500,
                    Category = context.Categories.FirstOrDefault(x => x.Name == "a1111111111")
                });
                //CategoryId = 1 });
                context.Tovars.Add(new Tovar
                {
                    Name = "qwtyetywqewyury",
                    Price = 1000,
                    Category = context.Categories.FirstOrDefault(x => x.Name == "b2222222222")
                });
                //CategoryId = 2 });
                context.Tovars.Add(new Tovar
                {
                    Name = "zxcnbzxvxcz",
                    Price = 750,
                    Category = context.Categories.FirstOrDefault(x => x.Name == "a1111111111")
                });
                //CategoryId = 1 });

                context.SaveChanges();

            }
        }
    }
}

using ShopDAL.Interfaces;
using ShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Repositories
{
    public class CategoryRepository : IRepository<Category>//ShopRepository<Tovar>, IRepository<Tovar>
    {

        //public TovarRepository(MyDBContext ctx) : base(ctx)
        //{
        //}

        List<Category> list;
        public CategoryRepository()
        {
            list = new List<Category>
            {
                new Category{Id=1,Name="a1111111111"},
                new Category{Id=2,Name="b2222222222"},
                new Category{Id=3,Name="c3333333333"}
            };
        }

        public IEnumerable<Category> GetAll()
        {
            return list;
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

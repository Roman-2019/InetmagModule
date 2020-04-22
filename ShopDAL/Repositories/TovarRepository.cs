using ShopDAL.Interfaces;
using ShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Repositories
{
    public class TovarRepository : ShopRepository<Tovar>, IRepository<Tovar> //IRepository<Tovar>//
    {

        public TovarRepository(MyDBContext ctx) : base(ctx)
        {
        }
        //List<Tovar> list;
        //public TovarRepository()
        //{
        //    list = new List<Tovar>
        //    {
        //        new Tovar{Id=1,Name="ashdjshahkjdksjf",Price=500,CategoryId=1 },
        //        new Tovar{Id=2,Name="qwtyetywqewyury",Price=1000,CategoryId=2 },
        //        new Tovar{Id=3,Name="zxcnbzxvxcz",Price=750,CategoryId=1 }
        //    };
        //}
        //public IEnumerable<Tovar> GetAll()
        //{
        //    return list;
        //}

        //public Tovar GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }

}

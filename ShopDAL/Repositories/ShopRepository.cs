using ShopDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Repositories
{
    public class ShopRepository<T> : IRepository<T> where T : class
    {

        private readonly MyDBContext _ctx;
        DbSet<T> _dbSet;

        public ShopRepository(MyDBContext ctx)
        {
            _ctx = ctx;
            _dbSet = _ctx.Set<T>();
        }


        public IEnumerable<T> GetAll()
        {
            return _dbSet.AsNoTracking();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
    }
}

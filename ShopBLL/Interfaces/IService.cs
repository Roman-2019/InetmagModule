using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBLL.Interfaces
{
    public interface IService<TModel> where TModel : class
    {
        IEnumerable<TModel> GetAll();
        TModel GetById(int id);
    }

}

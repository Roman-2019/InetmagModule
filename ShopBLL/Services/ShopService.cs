using ShopBLL.Interfaces;
using ShopDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBLL.Services
{
    public abstract class ShopService<ModelBL, ModelDL> : IService<ModelBL>
        where ModelBL : class
        where ModelDL : class
    {
        public readonly IRepository<ModelDL> _repository;

        public ShopService(IRepository<ModelDL> repository)
        {
            _repository = repository;
        }
        public IEnumerable<ModelBL> GetAll()
        {
            var models = _repository.GetAll().ToList();

            return Map(models);
        }

        public ModelBL GetById(int id)
        {
            var model = _repository.GetById(id);

            return Map(model);
        }
        public abstract ModelBL Map(ModelDL modelDL);
        public abstract ModelDL Map(ModelBL modelBL);

        public abstract IEnumerable<ModelBL> Map(IList<ModelDL> modelsDL);
        public abstract IEnumerable<ModelDL> Map(IList<ModelBL> modelsBL);
    }

}

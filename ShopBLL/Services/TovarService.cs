using AutoMapper;
using ShopBLL.Interfaces;
using ShopBLL.Models;
using ShopDAL.Interfaces;
using ShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBLL.Services
{
    public class TovarService : ShopService<TovarModel, Tovar>, ITovarService
    {

        public readonly IMapper _mapper;

        public TovarService(IRepository<Tovar> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public override TovarModel Map(Tovar modelDL)
        {
            return _mapper.Map<TovarModel>(modelDL);
        }

        public override Tovar Map(TovarModel modelBL)
        {
            return _mapper.Map<Tovar>(modelBL);
        }

        public override IEnumerable<TovarModel> Map(IList<Tovar> tovars)
        {
            return _mapper.Map<IEnumerable<TovarModel>>(tovars);
        }

        public override IEnumerable<Tovar> Map(IList<TovarModel> tovarsModel)
        {
            return _mapper.Map<IEnumerable<Tovar>>(tovarsModel);
        }
    }

}

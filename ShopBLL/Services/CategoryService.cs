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
    public class CategoryService : ShopService<CategoryModel, Category>, ICategoryService
    {

        public readonly IMapper _mapper;

        public CategoryService(IRepository<Category> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public override CategoryModel Map(Category modelDL)
        {
            return _mapper.Map<CategoryModel>(modelDL);
        }

        public override Category Map(CategoryModel modelBL)
        {
            return _mapper.Map<Category>(modelBL);
        }

        public override IEnumerable<CategoryModel> Map(IList<Category> categories)
        {
            return _mapper.Map<IEnumerable<CategoryModel>>(categories);
        }

        public override IEnumerable<Category> Map(IList<CategoryModel> categoriesModel)
        {
            return _mapper.Map<IEnumerable<Category>>(categoriesModel);
        }
    }
}

using AutoMapper;
using ShopBLL.Models;
using ShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBLL
{
    public class BLLAutomapperProfile: Profile
    {
        public BLLAutomapperProfile()
        {
            CreateMap<TovarModel, Tovar>()
                .ForMember(x => x.Category, y => y.MapFrom(x => x.CategoryModels))
                .ForMember(x => x.CategoryId, y => y.MapFrom(x => x.CategoryModelId))
                .ReverseMap();

            CreateMap<CategoryModel, Category>().ReverseMap();
        }
    }
}

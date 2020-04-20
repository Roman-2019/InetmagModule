using AutoMapper;
using ShopAPI.Models;
using ShopBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopAPI.App_Start
{
    public class WebApiAutomapperProfile: Profile
    {
        public WebApiAutomapperProfile()
        {
            CreateMap<TovarApiModel, TovarModel>()
           .ForMember(x => x.CategoryModels, y => y.MapFrom(x => x.CategoryApiModels))
           .ForMember(x => x.CategoryModelId, y => y.MapFrom(x => x.CategoryApiModelId))
           .ReverseMap();

            CreateMap<CategoryApiModel, CategoryModel>().ReverseMap();
        }

    }
}
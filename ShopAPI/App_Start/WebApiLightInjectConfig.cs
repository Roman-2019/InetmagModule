using AutoMapper;
using LightInject;
using ShopBLL;
using ShopBLL.Interfaces;
using ShopBLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ShopAPI.App_Start
{
    public class WebApiLightInjectConfig
    {
        public static void Configurate()
        {
            var container = new ServiceContainer();

            container.RegisterApiControllers();

            container.EnablePerWebRequestScope();

            var config = new MapperConfiguration(cfg => cfg.AddProfiles(
                 new List<Profile>() { new WebApiAutomapperProfile(), new BLLAutomapperProfile() }));

            container.Register(c => config.CreateMapper());

            container = BLLLightInjectConfig.Configuration(container);

            container.Register<ITovarService, TovarService>();
            container.Register<ICategoryService, CategoryService>();

            container.EnableWebApi(GlobalConfiguration.Configuration);
        }

    }
}
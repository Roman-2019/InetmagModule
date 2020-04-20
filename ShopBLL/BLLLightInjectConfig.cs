using LightInject;
using ShopDAL;
using ShopDAL.Interfaces;
using ShopDAL.Models;
using ShopDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBLL
{
    public static class BLLLightInjectConfig
    {
        public static ServiceContainer Configuration(ServiceContainer container)
        {
            container.Register<MyDBContext>(factory => new MyDBContext());

            container.Register<IRepository<Tovar>, TovarRepository>();
            container.Register<IRepository<Category>, CategoryRepository>();

            return container;
        }

    }
}

using AutoMapper;
using IyibankAppService.Data.Infrastructure;
using IyibankAppService.Data.Repository;
using IyibankAppService.Models.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace IyibankAppService.ApiService
{
    public static class ServiceInjection
    {
        public static AppServiesBuilder AddService(this AppServiesBuilder builder)
        {
            var mapper = new MapperConfiguration(cfg => { cfg.AddProfile<MappingProfile>(); });
            builder.AddSingleton(mapper.CreateMapper());
            AddWebService(builder);
            return builder;
        }

        private static void AddWebService(AppServiesBuilder builder)
        {
            builder.AddScoped(typeof(IShopService), typeof(ShopService));
            builder.AddScoped(typeof(IShopRepository), typeof(ShopRepository));
        }
    }
}

using AutoMapper;
using IyibankAppService.Data.Infrastructure;
using IyibankAppService.Data.Repository;
using IyibankAppService.Models.Mapping;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace IyibankAppService.ApiService
{
    public static class ServiceInjection
    {
        public static AppServiesBuilder AddService(this IServiceCollection services)
        {
            var builder = new AppServiesBuilder(services);
            builder.AddScoped(typeof(IShopService), typeof(ShopService));
            builder.AddScoped(typeof(IShopRepository), typeof(ShopRepository));
            return builder;

        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using System;

namespace IyibankAppService.Data.Infrastructure
{
    public class AppServiesBuilder
    {
        public AppServiesBuilder(IServiceCollection services)
        {
            Services = services;
        }

        public IServiceCollection Services { get; }

        public AppServiesBuilder AddScoped(Type serviceType)
        {
            Services.AddScoped(serviceType);
            return this;
        }

        public AppServiesBuilder AddTransient<TService, TImplementation>() where TService : class
            where TImplementation : class, TService
        {
            Services.AddTransient<TService, TImplementation>();
            return this;
        }

        public AppServiesBuilder AddScoped(Type serviceType, Type concreteType)
        {
            Services.AddScoped(serviceType, concreteType);
            return this;
        }

        public AppServiesBuilder AddScoped<T>() where T : class
        {
            Services.AddScoped<T>();
            return this;
        }

        public AppServiesBuilder AddSingleton<TService, TImplementation>() where TService : class
            where TImplementation : class, TService
        {
            Services.AddSingleton<TService, TImplementation>();
            return this;
        }

        public AppServiesBuilder AddSingleton<TService>(TService implementationInstance) where TService : class
        {
            Services.AddSingleton(implementationInstance);
            return this;
        }
    }
}

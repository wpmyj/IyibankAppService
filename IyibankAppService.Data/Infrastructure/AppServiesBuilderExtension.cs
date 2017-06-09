using Microsoft.Extensions.DependencyInjection;

namespace IyibankAppService.Data.Infrastructure
{
    public static class AppServiesBuilderExtension
    {
        public static AppServiesBuilder AddUnitOfWork(this IServiceCollection services)
        {
            var builder = new AppServiesBuilder(services);
            return builder;
        }
    }
}

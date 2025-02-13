using Microsoft.Extensions.DependencyInjection;
using Sample.Contracts.Data.Repositories;
using Sample.Infrastructure.Data.Repositories;

namespace Sample.Core
{
    public static class ServiceExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ISampleRepository, SampleRepository>();
        }
    }
}
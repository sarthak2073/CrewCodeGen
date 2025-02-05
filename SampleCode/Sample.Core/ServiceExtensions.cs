using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Sample.Core
{
    /// <summary>
    /// Static class responsible for adding core services to the IServiceCollection
    /// </summary>
    public static class ServiceExtensions
    {
        /// <summary>
        /// Adds core services to the IServiceCollection
        /// </summary>
        /// <param name="services">The IServiceCollection to add services to</param>
        public static void AddCore(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
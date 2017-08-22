using DataHippo.Repositories.Contracts;
using DataHippo.Repositories.Implementation;
using DataHippo.Services.Contracts;
using DataHippo.Services.Implementation;
using DataHippo.Services.Repositories.Contracts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataHippo.WebApi.Configuration
{
    public static class IoCConfiguration
    {
        public static void Register(IServiceCollection services)
        {
            RegisterRepositories(services);
            RegisterServices(services);
        }

        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<ITestService, TestService>();
            services.AddTransient<IApartmentService, ApartmentService>();
        }

        public static void RegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IMongoDbRepository, MongoDbRepository>();
            services.AddTransient<ITestRepository, TestRepository>();
            services.AddTransient<IApartmentRepository, ApartmentRepository>();
        }

        public static void RegisterConfiguration(IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddSingleton<IConfiguration>(configuration);
        }
    }
}

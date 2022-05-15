using WstrzykiwanieSerwisów.Interfaces;
using WstrzykiwanieSerwisów.Repositories;
using WstrzykiwanieSerwisów.Services;

namespace WstrzykiwanieSerwisów
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProjectService(this
        IServiceCollection services)
        {
            services.AddTransient<IPersonService,
            PersonService>();
            services.AddTransient<IPersonRepository,
            PersonRepository>();
            return services;
        }
            
    }
}
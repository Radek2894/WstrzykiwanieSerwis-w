using Data.Repository;
using Services;
using WstrzykiwanieSerwisów.Interfaces;



namespace WstrzykiwanieSerwisów
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProjectService(this
        IServiceCollection services)
        {
            services.AddTransient<IPersonService, PersonService>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            return services;
        }
            
    }
}
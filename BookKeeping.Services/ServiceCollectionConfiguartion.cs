using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace BookKeeping.Services
{
    public class ServiceCollectionConfiguartion
    {
        public IServiceCollection ServiceCollection(IServiceCollection service)
        {
            //service.AddScoped<IServiceCollection, ServiceCollection>();
            return service;
        }
    }
}

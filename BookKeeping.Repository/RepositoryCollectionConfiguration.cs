using Microsoft.Extensions.DependencyInjection;

namespace BookKeeping.Repository
{
    public class RepositoryCollectionConfiguration
    {
        public IServiceCollection RepositoryCollection(IServiceCollection service)
        {
            //service.AddScoped<>();
            return service;
        }
    }
}

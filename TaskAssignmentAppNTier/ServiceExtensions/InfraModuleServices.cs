using TaskAssigmentApp.Domain.Services;
using TaskAssignmentApp.Application.Services;
using TaskAssignmentApp.Infrastructure.ORM.EntityFramework;

namespace TaskAssignmentAppNTier.ServiceExtensions
{
  public static class InfraModuleServices
  {
    public static IServiceCollection RegisterInfraServices(this IServiceCollection services)
    {

      services.AddScoped<ICustomerRepository, EFCustomerRepository>();
      return services;
    }
  }
}

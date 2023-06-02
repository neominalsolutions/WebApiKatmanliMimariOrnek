using TaskAssigmentApp.Domain.Services;
using TaskAssignmentApp.Application.Services;
using TaskAssignmentApp.Infrastructure.ORM.EntityFramework;

namespace TaskAssignmentAppNTier.ServiceExtensions
{
  public static class DomainModuleServices
  {
    public static IServiceCollection RegisterDomainServices(this IServiceCollection services)
    {

      services.AddScoped<ITicketAssignment, TicketAssignmentService>();
      services.AddScoped<ITicketAssignmentCheckService, TicketAssignmentWeeklyCheckService>();
      services.AddScoped<ITicketRepository, EFTicketRepository>();

      services.AddScoped<IEmployeeRepository, EFEmployeeRepository>();
      return services;
    }
  }
}

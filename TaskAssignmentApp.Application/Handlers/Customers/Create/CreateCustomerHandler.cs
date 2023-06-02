using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAssigmentApp.Domain.Services;
using TaskAssignmentApp.Application.Dtos;

namespace TaskAssignmentApp.Application.Handlers.Customers.Create
{
  public class CreateCustomerHandler : IRequestHandler<CreateCustomerDto>
  {
    private readonly ICustomerRepository customerRepository;

    public CreateCustomerHandler(ICustomerRepository customerRepository)
    {
      this.customerRepository = customerRepository;
    }

    public Task Handle(CreateCustomerDto request, CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }
  }
}

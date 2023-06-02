using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAssigmentApp.Domain.Entities;
using TaskAssignmentApp.Application.Dtos;

namespace TaskAssignmentApp.Application.Handlers.Customers.Create
{
  public class CreateCustomerValidator:AbstractValidator<CreateCustomerDto>
  {
    public CreateCustomerValidator()
    {
      //RuleFor(x => x.Id).NotNull().WithMessage("Id boş geçilemez");

    }
  }
}

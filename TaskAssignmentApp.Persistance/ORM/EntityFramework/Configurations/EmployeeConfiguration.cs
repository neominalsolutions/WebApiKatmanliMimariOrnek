using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAssigmentApp.Domain.Entities;

namespace TaskAssignmentApp.Persistance.ORM.EntityFramework.Configurations
{
  internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
  {
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
      builder.HasIndex(x => x.Name).IsUnique();

      //throw new NotImplementedException();
    }
  }
}

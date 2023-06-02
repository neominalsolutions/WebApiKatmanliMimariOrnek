﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAssignmentApp.Application.Dtos
{
  public class CreateUserRequestDto
  {
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public List<string> Roles { get; set; }


  }
}

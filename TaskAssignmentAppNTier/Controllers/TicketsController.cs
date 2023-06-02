using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TaskAssignmentApp.Application.Dtos;
using TaskAssignmentApp.Application.Services;
using TaskAssignmentAppNTier.Attributes;

namespace TaskAssignmentAppNTier.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
  public class TicketsController : ControllerBase
  {
    private readonly IMediator _mediator;

    public TicketsController(IMediator mediator)
    {
      _mediator = mediator;
    }


    [HttpPost("assing-new")]

    //[Role("Admin")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
    public async Task<IActionResult> AssignTicketApplicationLayer([FromBody] TicketAssignmentRequestDto dto)
    {

     
        // mediator gelen request işlemek için send methodu kullanıyor
        var response = await _mediator.Send(dto);

      return StatusCode(StatusCodes.Status200OK,response);

      //return StatusCode(StatusCodes.Status200OK,response);

    

      // var response = mediator.HandleAsync(request);

    }


  }
}

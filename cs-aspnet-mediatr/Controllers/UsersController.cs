using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using cs_aspnet_mediatr.Commands;
using cs_aspnet_mediatr.Handlers;
using cs_aspnet_mediatr.Models;
using cs_aspnet_mediatr.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace cs_aspnet_mediatr.Controllers
{
  [ApiController]
  [Route("users")]
  public class UsersController : ControllerBase
  {
    private readonly ILogger<UsersController> _logger;
    private readonly IMediator _mediator;

    public UsersController(ILogger<UsersController> logger , IMediator mediator)
    {
      _logger = logger;
      _mediator = mediator;
    }

    [HttpGet]
    public async Task<List<User>> Get()
    {
      var query = new GetUsersQuery();
      var result = await _mediator.Send(query);

      return result;
    }

    [HttpGet]
    [Route("{id:guid}")]
    public async Task<ActionResult<User>> GetUserById(Guid id)
    {
      var query = new GetUserByIdQuery(id);
      var result = await _mediator.Send(query);

      return result is not null ? result : NotFound();
    }
    
    [HttpPut]
    [Route("{id:guid}")]
    public async Task<ActionResult<User>> UpdateUserById([FromRoute] Guid id, [FromBody] User user)
    {
      var query = new UpdateUserByIdCommand(id, user.Name);
      var result = await _mediator.Send(query);

      return result is not null ? result : NotFound();
    }
  }
}
using System;
using cs_aspnet_mediatr.Models;
using MediatR;

namespace cs_aspnet_mediatr.Handlers
{
  public class GetUserByIdQuery : IRequest<User>
  {
    public Guid Id { get; }

    public GetUserByIdQuery(Guid id)
    {
      Id = id;
    }
  }
}
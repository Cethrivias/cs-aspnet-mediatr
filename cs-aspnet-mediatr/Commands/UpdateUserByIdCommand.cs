using System;
using cs_aspnet_mediatr.Models;
using MediatR;

namespace cs_aspnet_mediatr.Commands
{
  public class UpdateUserByIdCommand : IRequest<User>
  {
    public UpdateUserByIdCommand(Guid id, string name)
    {
      Id = id;
      Name = name;
    }

    public Guid Id { get; }
    public string Name { get; }
  }
}
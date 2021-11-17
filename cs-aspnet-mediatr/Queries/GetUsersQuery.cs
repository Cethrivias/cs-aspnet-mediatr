using System.Collections.Generic;
using cs_aspnet_mediatr.Models;
using MediatR;

namespace cs_aspnet_mediatr.Queries
{
  public class GetUsersQuery : IRequest<List<User>>
  {
    
  }
}
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using cs_aspnet_mediatr.Models;
using cs_aspnet_mediatr.Queries;
using cs_aspnet_mediatr.Repositories;
using MediatR;

namespace cs_aspnet_mediatr.Handlers
{
  public class GetUsersHandler : IRequestHandler<GetUsersQuery, List<User>>
  {
    private readonly IUserRepository _userRepository;

    public GetUsersHandler(IUserRepository userRepository)
    {
      _userRepository = userRepository;
    }

    public Task<List<User>> Handle(GetUsersQuery request, CancellationToken cancellationToken) => _userRepository.Get();
  }
}
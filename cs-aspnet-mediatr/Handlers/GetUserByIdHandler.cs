using System.Threading;
using System.Threading.Tasks;
using cs_aspnet_mediatr.Models;
using cs_aspnet_mediatr.Repositories;
using MediatR;

namespace cs_aspnet_mediatr.Handlers
{
  public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, User>
  {
    private IUserRepository _userRepository;

    public GetUserByIdHandler(IUserRepository userRepository)
    {
      _userRepository = userRepository;
    }

    public Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken) =>
      _userRepository.GetById(request.Id);
  }
}
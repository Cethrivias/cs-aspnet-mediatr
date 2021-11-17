using System.Threading;
using System.Threading.Tasks;
using cs_aspnet_mediatr.Commands;
using cs_aspnet_mediatr.Models;
using cs_aspnet_mediatr.Repositories;
using MediatR;

namespace cs_aspnet_mediatr.Handlers
{
  public class UpdateUserByIdHandler : IRequestHandler<UpdateUserByIdCommand, User>
  {
    private readonly IUserRepository _userRepository;

    public UpdateUserByIdHandler(IUserRepository userRepository)
    {
      _userRepository = userRepository;
    }

    public Task<User> Handle(UpdateUserByIdCommand request, CancellationToken cancellationToken)
    {
      var user = new User
      {
        Id = request.Id,
        Name = request.Name
      };
      
      return _userRepository.UpdateById(user.Id, user);
    }
  }
}
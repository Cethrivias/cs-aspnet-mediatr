using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cs_aspnet_mediatr.Models;

namespace cs_aspnet_mediatr.Repositories
{
  public class UserRepository : IUserRepository
  {
    private List<User> _users = new()
    {
      new User
      {
        Id = Guid.NewGuid(),
        Name = "User 1",
      },
      new User
      {
        Id = Guid.NewGuid(),
        Name = "User 2",
      }
    };

    public Task<List<User>> Get() => Task.FromResult(_users);

    public Task<User> GetById(Guid id) => Task.FromResult(_users.FirstOrDefault(it => it.Id == id));

    public Task<User> UpdateById(Guid id, User user)
    {
      var existingUser = _users.FirstOrDefault(it => it.Id == id);

      if (existingUser is null) {
        return Task.FromResult((User)null);
      }
      
      existingUser.Name = user.Name;

      return Task.FromResult(existingUser);
    }
  }
}
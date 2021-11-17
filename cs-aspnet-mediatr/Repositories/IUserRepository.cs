using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using cs_aspnet_mediatr.Models;

namespace cs_aspnet_mediatr.Repositories
{
  public interface IUserRepository
  {
    Task<List<User>> Get();

    Task<User> GetById(Guid id);

    Task<User> UpdateById(Guid id, User user);
  }
}
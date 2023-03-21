using System.Collections.Generic;
using System.Threading.Tasks;
using TodoData.Entity.Base.Entities;

namespace TodoList.Api.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetUserList();
    }
}

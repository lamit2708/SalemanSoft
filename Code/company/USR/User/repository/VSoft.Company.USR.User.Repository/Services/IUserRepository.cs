using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.USR.User.Data.Db.Contexts;
using VSoft.Company.USR.User.Data.Entity.Models;

namespace VSoft.Company.USR.User.Repository.Services;

public interface IUserRepository : IEfcRepositoryEntityMgmtId<UserDbContext, MUserEntity, long>
{

    string? GetFullName(long? id);

    Task<string?> GetFullNameAsync(long? id);
}

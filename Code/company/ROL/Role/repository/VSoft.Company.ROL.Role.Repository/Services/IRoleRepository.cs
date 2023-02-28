using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.ROL.Role.Data.Db.Contexts;
using VSoft.Company.ROL.Role.Data.Entity.Models;

namespace VSoft.Company.ROL.Role.Repository.Services;

public interface IRoleRepository : IEfcRepositoryEntityMgmtId<RoleDbContext, MRoleEntity, long>
{

    string? GetFullName(long? id);

    Task<string?> GetFullNameAsync(long? id);
}

using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.TEA.Team.Data.Db.Contexts;
using VSoft.Company.TEA.Team.Data.Entity.Models;

namespace VSoft.Company.TEA.Team.Repository.Services;

public interface ITeamRepository : IEfcRepositoryEntityMgmtId<TeamDbContext, MTeamEntity, long>
{

    string? GetFullName(long? id);

    Task<string?> GetFullNameAsync(long? id);
}

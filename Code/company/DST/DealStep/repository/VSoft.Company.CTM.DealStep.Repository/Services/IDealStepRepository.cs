using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.DST.DealStep.Data.Db.Contexts;
using VSoft.Company.DST.DealStep.Data.Entity.Models;

namespace VSoft.Company.DST.DealStep.Repository.Services;

public interface IDealStepRepository : IEfcRepositoryEntityMgmtId<DealStepDbContext, MDealStepEntity, long>
{

    string? GetFullName(long? id);

    Task<string?> GetFullNameAsync(long? id);
}

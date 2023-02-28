using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.DAC.DealActivity.Data.Db.Contexts;
using VSoft.Company.DAC.DealActivity.Data.Entity.Models;

namespace VSoft.Company.DAC.DealActivity.Repository.Services;

public interface IDealActivityRepository : IEfcRepositoryEntityMgmtId<DealActivityDbContext, MDealActivityEntity, long>
{

    string? GetFullName(long? id);

    Task<string?> GetFullNameAsync(long? id);
}

using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VSoft.Company.DST.DealStep.Data.Db.Contexts;
using VSoft.Company.DST.DealStep.Data.Entity.Models;
using VSoft.Company.DST.DealStep.Repository.Efc.Services;

namespace VSoft.Company.DST.DealStep.Repository.Efc.Provider.Services;

public class EfcDealStepRepository : EFcRepositoryEntityMgmtId<DealStepDbContext, MDealStepEntity, long>, IDealStepRepositoryEfc
{

    public EfcDealStepRepository(DealStepDbContext dbContext) : base(dbContext, dbContext.Items)
    {

    }

    public string? GetFullName(long? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.Name ?? string.Empty).FirstOrDefault();
    }

    public Task<string?> GetFullNameAsync(long? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.Name ?? string.Empty).FirstOrDefaultAsync() ;
    }
}

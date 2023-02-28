using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VSoft.Company.ACT.Activity.Data.Db.Contexts;
using VSoft.Company.ACT.Activity.Data.Entity.Models;
using VSoft.Company.ACT.Activity.Repository.Efc.Services;

namespace VSoft.Company.ACT.Activity.Repository.Efc.Provider.Services;

public class EfcActivityRepository : EFcRepositoryEntityMgmtId<ActivityDbContext, MActivityEntity, long>, IActivityRepositoryEfc
{

    public EfcActivityRepository(ActivityDbContext dbContext) : base(dbContext, dbContext.Items)
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

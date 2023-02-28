using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VSoft.Company.PRI.Priority.Data.Db.Contexts;
using VSoft.Company.PRI.Priority.Data.Entity.Models;
using VSoft.Company.PRI.Priority.Repository.Efc.Services;

namespace VSoft.Company.PRI.Priority.Repository.Efc.Provider.Services;

public class EfcPriorityRepository : EFcRepositoryEntityMgmtId<PriorityDbContext, MPriorityEntity, long>, IPriorityRepositoryEfc
{

    public EfcPriorityRepository(PriorityDbContext dbContext) : base(dbContext, dbContext.Items)
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

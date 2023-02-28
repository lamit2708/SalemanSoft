using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VSoft.Company.CSO.CustomerSource.Data.Db.Contexts;
using VSoft.Company.CSO.CustomerSource.Data.Entity.Models;
using VSoft.Company.CSO.CustomerSource.Repository.Efc.Services;

namespace VSoft.Company.CSO.CustomerSource.Repository.Efc.Provider.Services;

public class EfcCustomerSourceRepository : EFcRepositoryEntityMgmtId<CustomerSourceDbContext, MCustomerSourceEntity, long>, ICustomerSourceRepositoryEfc
{

    public EfcCustomerSourceRepository(CustomerSourceDbContext dbContext) : base(dbContext, dbContext.Items)
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

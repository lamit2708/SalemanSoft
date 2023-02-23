using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VSoft.Company.CTM.Customer.Data.Db.Contexts;
using VSoft.Company.CTM.Customer.Data.Entity.Models;
using VSoft.Company.CTM.Customer.Repository.Efc.Services;

namespace VSoft.Company.CTM.Customer.Repository.Efc.Provider.Services;

public class EfcCustomerRepository : EFcRepositoryEntityMgmtId<CustomerDbContext, MCustomerEntity, int>, ICustomerRepositoryEfc
{

    public EfcCustomerRepository(CustomerDbContext dbContext) : base(dbContext, dbContext.Items)
    {

    }

    public string? GetFullName(int? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.FullName ?? string.Empty).FirstOrDefault();
    }

    public Task<string?> GetFullNameAsync(int? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.FullName ?? string.Empty).FirstOrDefaultAsync() ;
    }
}

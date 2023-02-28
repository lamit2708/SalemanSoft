using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VSoft.Company.UCU.UserCustomer.Data.Db.Contexts;
using VSoft.Company.UCU.UserCustomer.Data.Entity.Models;
using VSoft.Company.UCU.UserCustomer.Repository.Efc.Services;

namespace VSoft.Company.UCU.UserCustomer.Repository.Efc.Provider.Services;

public class EfcUserCustomerRepository : EFcRepositoryEntityMgmtId<UserCustomerDbContext, MUserCustomerEntity, long>, IUserCustomerRepositoryEfc
{

    public EfcUserCustomerRepository(UserCustomerDbContext dbContext) : base(dbContext, dbContext.Items)
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

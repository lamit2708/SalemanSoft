using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VSoft.Company.PRO.Product.Data.Db.Contexts;
using VSoft.Company.PRO.Product.Data.Entity.Models;
using VSoft.Company.PRO.Product.Repository.Efc.Services;

namespace VSoft.Company.PRO.Product.Repository.Efc.Provider.Services;

public class EfcProductRepository : EFcRepositoryEntityMgmtId<ProductDbContext, MProductEntity, int>, IProductRepositoryEfc
{

    public EfcProductRepository(ProductDbContext dbContext) : base(dbContext, dbContext.Items)
    {

    }

    public string? GetFullName(int? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.Name ?? string.Empty).FirstOrDefault();
    }

    public Task<string?> GetFullNameAsync(int? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.Name ?? string.Empty).FirstOrDefaultAsync() ;
    }
}

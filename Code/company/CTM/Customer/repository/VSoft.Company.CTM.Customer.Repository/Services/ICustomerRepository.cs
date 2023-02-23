using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.CTM.Customer.Data.Db.Contexts;
using VSoft.Company.CTM.Customer.Data.Entity.Models;

namespace VSoft.Company.CTM.Customer.Repository.Services;

public interface ICustomerRepository : IEfcRepositoryEntityMgmtId<CustomerDbContext, MCustomerEntity, int>
{

    string? GetFullName(int? id);

    Task<string?> GetFullNameAsync(int? id);
}

﻿using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.PRI.Priority.Data.Db.Contexts;
using VSoft.Company.PRI.Priority.Data.Entity.Models;

namespace VSoft.Company.PRI.Priority.Repository.Services;

public interface IPriorityRepository : IEfcRepositoryEntityMgmtId<PriorityDbContext, MPriorityEntity, long>
{

    string? GetFullName(long? id);

    Task<string?> GetFullNameAsync(long? id);
}

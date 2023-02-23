using VegunSoft.Framework.Efc.Migrate.Provider.SqlServer.Services;
using VSoft.Company.CTM.Customer.Data.Db.Contexts;
using VSoft.Company.CTM.Customer.Data.Entity.Models;
await new EfcSingleMigrateServiceSqlServer<CustomerDbContext, MCustomerEntity>().LogCount();
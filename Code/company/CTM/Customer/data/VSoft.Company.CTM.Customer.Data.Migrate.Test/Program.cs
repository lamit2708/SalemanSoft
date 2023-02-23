using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Efc.Migrate.Provider.Sqlite.Services;
using VSoft.Company.CTM.Customer.Data.Db.Contexts;
using VSoft.Company.CTM.Customer.Data.Entity.Models;
await new EfcSingleMigrateServiceSqlite<CustomerDbContext, MCustomerEntity>().LogCustom(async (dbContext) => {
    var list = dbContext.Items.Where(x => x.FullName == "Đặng Thế Nhân").Select(p => new MCustomerEntityBasic {Id = p.Id, FullName = p.FullName }).ToList();
    list.ForEach(data =>
    {
        if (data != null)
        {
            Console.WriteLine($"--------------------------");
            Console.WriteLine($"Id : {data.Id}");
            Console.WriteLine($"FullName : {data.FullName}");
        }
    });
    Console.WriteLine($"=========================");

    var fullName =  await dbContext.Items.Where(x => x.Id == 1).Select(p => p.FullName).FirstOrDefaultAsync();
    Console.WriteLine($"FullName : {fullName}");
});
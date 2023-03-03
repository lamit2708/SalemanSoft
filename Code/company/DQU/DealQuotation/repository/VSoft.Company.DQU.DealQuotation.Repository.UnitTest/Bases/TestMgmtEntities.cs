using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Repository.UnitTest.Bases;
using VSoft.Company.DQU.DealQuotation.Data.Db.Contexts;
using VSoft.Company.DQU.DealQuotation.Repository.Efc.Provider.Services;
using VSoft.Company.DQU.DealQuotation.Repository.Services;
using Model = VSoft.Company.DQU.DealQuotation.Data.Entity.Models.MDealQuotationEntity;

namespace VSoft.Company.DQU.DealQuotation.Repository.UnitTest.Bases;


public class TestMgmtEntities : RepositoryTest<DealQuotationDbContext, IDealQuotationRepository, Model>
{
    protected override List<string>? LogFields { get; set; } = new List<string>()
    {
        nameof(Model.Id),

        nameof(Model.DealId),
       
    };

    protected override void RegisterServices()
    {
        ServiceCollection?.AddDbContext<DealQuotationDbContext>((builder) =>
        {
            builder.UseMySQL(DbConnectionCfg).EnableSensitiveDataLogging();
        });
        ServiceCollection?.AddScoped<IDealQuotationRepository, EfcDealQuotationRepository>();
    }

    protected async Task TestGetFullNameByIdAsync(long id)
    {
        await RunTest("TestGetByIdAsync", async (r, l) =>
        {
            var e = await (r?.GetFullNameAsync(id) ?? Task.FromResult<string?>(null));
            l(e ?? string.Empty);
        });
    }

    protected async Task TestGetByIdAsync(long id)
    {
        await RunTest("TestGetByIdAsync", async (r, l) =>
        {
            var e = await (r?.GetByIdAsync(id) ?? Task.FromResult<Model?>(null));
            LogEntity(e, l);
        });
    }

    protected async Task TestCreateAsync(Model entity)
    {
        await RunTest("TestAddDealQuotation", async (r, l) =>
        {
            var e = await (r?.CreateAsync(entity) ?? Task.FromResult<Model?>(null));
            LogEntity(e, l);
        });

    }

    protected async Task TestCreateRangeAsync(params Model[] entities)
    {
        await RunTest("TestAddDealQuotation", async (r, l) =>
        {
            var rs = await (r?.CreateRangeAsync(entities) ?? Task.FromResult<IEnumerable<Model>?>(null));
            LogEntities(rs, l);
        });

    }

    protected async Task TestUpdateAsync(Model newEntity)
    {
        await RunTest("TestUpdateDealQuotation", async (r, l) =>
        {
            var dbEntity = await (r?.GetByIdAsync(newEntity.Id) ?? Task.FromResult<Model?>(null));
            if (dbEntity != null)
            {
                var e = await (r?.UpdateAsync(dbEntity, newEntity) ?? Task.FromResult<Model?>(null));
                LogEntity(e, l);
                return;
            }
            l($"Id: {newEntity?.Id} update false!");
        });

    }

    protected async Task TestUpdateRangeAsync(params Model[] entities)
    {
        await RunTest("TestAddDealQuotation", async (r, l) =>
        {
            var rs = await (r?.UpdateRangeAsync(entities) ?? Task.FromResult<IEnumerable<Model>?>(null));
            LogEntities(rs, l);
        });

    }

    protected async Task TestSaveRangeAsync(Model[] createEntities, Model[] updateEntities, long[]? deleteEntitiesIds)
    {
        await RunTest("TestAddDealQuotation", async (r, l) =>
        {
            var deleteEntities = deleteEntitiesIds != null ? (await r.GetByIdsAsync(deleteEntitiesIds)) : null;
            var rs = await (r?.SaveRangeAsync(new MSaveRangeParams<Model>() {
                CreateEntities = createEntities,
                UpdateEntities = updateEntities,
                DeleteEntities = deleteEntities,

            }) ?? Task.FromResult<MSaveRangeResults<Model>?>(null));
            LogEntities(rs?.CreateEntities, l);
            LogEntities(rs?.UpdateEntities, l);
            LogEntities(rs?.DeleteEntities, l);
        });

    }

    protected async Task TestSaveRangeTransactionAsync(Model[] createEntities, Model[] updateEntities, long[]? deleteEntitiesIds)
    {
        await RunTest("TestAddDealQuotation", async (r, l) =>
        {
            var deleteEntities = deleteEntitiesIds != null ? (await r.GetByIdsAsync(deleteEntitiesIds)) : null;
            var rs = await (r?.SaveRangeTransactionAsync(new MSaveRangeParams<Model>()
            {
                CreateEntities = createEntities,
                UpdateEntities = updateEntities,
                DeleteEntities = deleteEntities,

            }) ?? Task.FromResult<MSaveRangeResults<Model>?>(null));
            LogEntities(rs?.CreateEntities, l);
            LogEntities(rs?.UpdateEntities, l);
            LogEntities(rs?.DeleteEntities, l);
        });

    }

    protected async Task TestDeleteAsync(long id)
    {
        await RunTest("TestDelDealQuotation", async (r, l) =>
        {
            var customer = await (r?.GetByIdAsync(id) ?? Task.FromResult<Model?>(null));
            if (customer != null)
            {

                var e = await (r?.DeleteAsync(customer) ?? Task.FromResult<Model?>(null));
                LogEntity(customer, l);
                return;
            }
            l($"Id: {customer?.Id} delete false!");
        });

    }

    protected async Task TestDeleteRangeAsync(params long[] ids)
    {
        await RunTest("TestDelDealQuotation", async (r, l) =>
        {
            var rsEntities = await (r?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<Model>?>(null));
            if (rsEntities != null)
            {

                var rs = await (r?.DeleteRangeAsync(rsEntities) ?? Task.FromResult<IEnumerable<Model>?>(null));
                LogEntities(rs, l);
                return;
            }
            l($"Ids: {ids} delete false!");
        });

    }
}
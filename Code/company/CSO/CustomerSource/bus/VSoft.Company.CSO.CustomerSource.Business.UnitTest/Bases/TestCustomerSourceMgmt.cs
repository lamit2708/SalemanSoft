﻿using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.UnitTest.Bases;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;
using VSoft.Company.CSO.CustomerSource.Business.Dto.Request;
using VSoft.Company.CSO.CustomerSource.Business.Provider.Services;
using VSoft.Company.CSO.CustomerSource.Business.Services;
using VSoft.Company.CSO.CustomerSource.Data.Db.Contexts;
using VSoft.Company.CSO.CustomerSource.Repository.Efc.Provider.Services;
using VSoft.Company.CSO.CustomerSource.Repository.Services;
using Model = VSoft.Company.CSO.CustomerSource.Business.Dto.Data.CustomerSourceDto;
namespace VSoft.Company.CSO.CustomerSource.Business.UnitTest.Bases
{
    public class TestCustomerSourceMgmt : BusinessTest<Model>
    {
        protected override List<string>? LogFields { get; set; } = new List<string>()
        {
            nameof(Model.Id),
            nameof(Model.Name),
           
        };

        protected override void RegisterServices()
        {
            ServiceCollection?.AddDbContext<CustomerSourceDbContext>((builder) =>
            {
                builder.UseMySQL(new MDbConnectionCfg());
            });

            ServiceCollection?.AddScoped<ICustomerSourceRepository, EfcCustomerSourceRepository>();
            ServiceCollection?.AddScoped<ICustomerSourceMgmtBus, CustomerSourceMgmtBus>();
        }


        protected async Task TestGetFullNameByIdAsync(MDtoRequestFindByLong dto)
        {
            await RunTest("TestGetByIdAsync", async (log) =>
            {
                var bus = GetService<ICustomerSourceMgmtBus>();
                if (bus == null) return;
                var res = await bus.GetFullNameAsync(dto);
                LogResponse(res, log, "FullName");
            });
        }


        protected async Task TestFindAsync(MDtoRequestFindByLong request)
        {
            await RunTest("TestFindAsync", async (log) =>
            {
                log($"Input Id: {request.Id}");
                var bus = GetService<ICustomerSourceMgmtBus>();
                if (bus == null) return;
                var res = await bus.FindAsync(request);
                LogResponse(res, log);
            });

        }

        protected async Task TestFindRangeAsync(MDtoRequestFindRangeByLongs request)
        {
            await RunTest("TestFindRangeAsync", async (log) =>
            {
                log($"Input Ids: {request.Ids}");
                var bus = GetService<ICustomerSourceMgmtBus>();
                if (bus == null) return;
                var res = await bus.FindRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestCreateAsync(CustomerSourceInsertDtoRequest request)
        {
            await RunTest("TestCreateAsync", async (log) =>
            {
                var dto = request.Data;
                LogDto(dto, log);
                var bus = GetService<ICustomerSourceMgmtBus>();
                if (bus == null) return;
                var res = await bus.CreateAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestCreateRangeAsync(CustomerSourceInsertRangeDtoRequest request)
        {
            await RunTest("TestCreateRangeAsync", async (log) =>
            {
                var dtos = request.Data;
                LogDtos(dtos, log);
                var bus = GetService<ICustomerSourceMgmtBus>();
                if (bus == null) return;
                var res = await bus.CreateRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestUpdateAsync(CustomerSourceUpdateDtoRequest request)
        {
            await RunTest("TestUpdateAsync", async (log) =>
            {
                var dto = request.Data;
                LogDto(dto, log);
                var bus = GetService<ICustomerSourceMgmtBus>();
                if (bus == null) return;
                var res = await bus.UpdateAsync(request);
                LogResponse(res, log);

            });
        }

        protected async Task TestUpdateRangeAsync(CustomerSourceUpdateRangeDtoRequest request)
        {
            await RunTest("TestUpdateRangeAsync", async (log) =>
            {
                var dtos = request.Data;
                LogDtos(dtos, log);
                var bus = GetService<ICustomerSourceMgmtBus>();
                if (bus == null) return;
                var res = await bus.UpdateRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestDeleteAsync(CustomerSourceDeleteDtoRequest request)
        {
            await RunTest("TestDeleteAsync", async (log) =>
            {
                log($"Input Id: {request.Id}");
                var bus = GetService<ICustomerSourceMgmtBus>();
                if (bus == null) return;
                var res = await bus.DeleteAsync(request);
                LogResponse(res, log);
            });

        }

        protected async Task TestDeleteRangeAsync(CustomerSourceDeleteRangeDtoRequest request)
        {
            await RunTest("TestDeleteRangeAsync", async (log) =>
            {
                log($"Input Ids: {request.Ids}");
                var bus = GetService<ICustomerSourceMgmtBus>();
                if (bus == null) return;
                var res = await bus.DeleteRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestSaveRangeAsync(CustomerSourceSaveRangeDtoRequest? request)
        {
            await RunTest("TestSaveRangeAsync", async (log) =>
            {
                var createDtos = request?.CreateData;
                var updateDtos = request?.UpdateData;
                var deleteIds = request?.DeleteIds;
                //LogDtos(createDtos, log);
                //LogDtos(updateDtos, log);
                var bus = GetService<ICustomerSourceMgmtBus>();
                if (bus == null) return;
                // var deleteEntities = deleteIds != null ? (await r.GetByIdsAsync(deleteEntitiesIds)) : null;
                var rs = await bus.SaveRangeAsync(request);
                LogDtos(rs?.CreatedData, log);
                LogDtos(rs?.UpdatedData, log);
                LogDtos(rs?.DeletedData, log);
            });

        }

        protected async Task TestSaveRangeTransactionAsync(CustomerSourceSaveRangeDtoRequest? request)
        {
            await RunTest("TestSaveRangeAsync", async (log) =>
            {
                var createDtos = request?.CreateData;
                var updateDtos = request?.UpdateData;
                var deleteIds = request?.DeleteIds;
                //LogDtos(createDtos, log);
                //LogDtos(updateDtos, log);
                var bus = GetService<ICustomerSourceMgmtBus>();
                if (bus == null) return;
                // var deleteEntities = deleteIds != null ? (await r.GetByIdsAsync(deleteEntitiesIds)) : null;
                var rs = await bus.SaveRangeTransactionAsync(request);
                LogDtos(rs?.CreatedData, log);
                LogDtos(rs?.UpdatedData, log);
                LogDtos(rs?.DeletedData, log);
            });

        }
    }
}
using VSoft.Company.DAC.DealActivity.Business.Dto.Request;
using VSoft.Company.DAC.DealActivity.Business.Dto.Response;
using VSoft.Company.DAC.DealActivity.Business.Services;
using VSoft.Company.DAC.DealActivity.Repository.Services;
using VSoft.Company.DAC.DealActivity.Data.Entity.Models;
using VSoft.Company.DAC.DealActivity.Business.Dto.Extension.Methods;
using VSoft.Company.DAC.DealActivity.Business.entity.Extension.Methods;
using VSoft.Company.DAC.DealActivity.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.DAC.DealActivity.Business.Provider.Services;

public class DealActivityMgmtBus : BusinessRepositoryService<DealActivityDto, IDealActivityRepository>, IDealActivityMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(DealActivityDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(DealActivityDto.Name),
        
    };

    public DealActivityMgmtBus(IDealActivityRepository customerRepository) : base(customerRepository)
    {

    }

    public MDtoResponseString GetFullName(MDtoRequestFindByLong request)
    {
        return GetValue<MDtoRequestFindByLong, MDtoResponseString, long, string>
        (
            nameof(GetFullName), request, "email",
            (id) => Repository?.GetFullName(id)
        );
    }

    public async Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByLong request)
    {
        return await GetValueAsync<MDtoRequestFindByLong, MDtoResponseString, long, string>
        (
            nameof(GetFullNameAsync), request, "email",
            async (id) => await (Repository?.GetFullNameAsync(id) ?? Task.FromResult<string?>(null))
        );
    }

    public DealActivityFindDtoResponse Find(MDtoRequestFindByLong request)
    {
        return Find<MDtoRequestFindByLong, DealActivityFindDtoResponse, long>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<DealActivityFindDtoResponse> FindAsync(MDtoRequestFindByLong request)
    {
        return await FindAsync<MDtoRequestFindByLong, DealActivityFindDtoResponse, long>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MDealActivityEntity?>(null)))?.GetDto()
        );
    }

    public DealActivityFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request)
    {
        return FindRange<MDtoRequestFindRangeByLongs, DealActivityFindRangeDtoResponse, long>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<DealActivityFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByLongs, DealActivityFindRangeDtoResponse, long>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MDealActivityEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public DealActivityInsertDtoResponse Create(DealActivityInsertDtoRequest request)
    {
        return Create<DealActivityInsertDtoRequest, DealActivityInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MDealActivityEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<DealActivityInsertDtoResponse> CreateAsync(DealActivityInsertDtoRequest request)
    {
        return await CreateAsync<DealActivityInsertDtoRequest, DealActivityInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MDealActivityEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MDealActivityEntity?>(new MDealActivityEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public DealActivityInsertRangeDtoResponse CreateRange(DealActivityInsertRangeDtoRequest request)
    {
        return CreateRange<DealActivityInsertRangeDtoRequest, DealActivityInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MDealActivityEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<DealActivityInsertRangeDtoResponse> CreateRangeAsync(DealActivityInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<DealActivityInsertRangeDtoRequest, DealActivityInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MDealActivityEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MDealActivityEntity>?>(Array.Empty<MDealActivityEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public DealActivityUpdateDtoResponse Update(DealActivityUpdateDtoRequest request)
    {
        return Update<DealActivityUpdateDtoRequest, DealActivityUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MDealActivityEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<DealActivityUpdateDtoResponse> UpdateAsync(DealActivityUpdateDtoRequest request)
    {
        return await UpdateAsync<DealActivityUpdateDtoRequest, DealActivityUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MDealActivityEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MDealActivityEntity?>(new MDealActivityEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public DealActivityUpdateRangeDtoResponse UpdateRange(DealActivityUpdateRangeDtoRequest request)
    {
        return UpdateRange<DealActivityUpdateRangeDtoRequest, DealActivityUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MDealActivityEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<DealActivityUpdateRangeDtoResponse> UpdateRangeAsync(DealActivityUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<DealActivityUpdateRangeDtoRequest, DealActivityUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MDealActivityEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MDealActivityEntity>?>(Array.Empty<MDealActivityEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public DealActivityDeleteDtoResponse Delete(DealActivityDeleteDtoRequest request)
    {
        return Delete<DealActivityDeleteDtoRequest, DealActivityDeleteDtoResponse, long>
        (
             request,
             (id) =>
             {
                 var inputEntity = Repository?.GetById(id);
                 var resultEntity = inputEntity != null ? Repository?.Delete(inputEntity) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public async Task<DealActivityDeleteDtoResponse> DeleteAsync(DealActivityDeleteDtoRequest request)
    {
        return await DeleteAsync<DealActivityDeleteDtoRequest, DealActivityDeleteDtoResponse, long>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MDealActivityEntity?>(new MDealActivityEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MDealActivityEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public DealActivityDeleteRangeDtoResponse DeleteRange(DealActivityDeleteRangeDtoRequest request)
    {
        return DeleteRange<DealActivityDeleteRangeDtoRequest, DealActivityDeleteRangeDtoResponse, long>
        (
             request,
             (ids) =>
             {
                 var inputEntities = Repository?.GetByIds(ids);
                 var resultEntities = Repository?.DeleteRange(inputEntities);
                 return resultEntities?.Select(e => e.GetDto()).ToArray();
             }
        );
    }

    public async Task<DealActivityDeleteRangeDtoResponse> DeleteRangeAsync(DealActivityDeleteRangeDtoRequest request)
    {
       return await DeleteRangeAsync<DealActivityDeleteRangeDtoRequest, DealActivityDeleteRangeDtoResponse, long>
       (
            request,
            async (ids) =>
            {
                var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MDealActivityEntity>?>(null));
                var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MDealActivityEntity>?>(null));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
       );
    }


    protected async Task<DealActivitySaveRangeDtoResponse> SaveRangeAsync(DealActivitySaveRangeDtoRequest request, Func<MSaveRangeParams<MDealActivityEntity>?, Task<MSaveRangeResults<MDealActivityEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new DealActivitySaveRangeDtoResponse()
        {
            IsSuccess = false,
            CreatedData = null,
            UpdatedData = null,
            DeletedData = null,
            Message = $"Không có các dữ liệu {ContextName} để thay đổi!",
        }.GetResponse(functionName);
        var createCount = createData?.Length ?? 0;
        var updateCount = updateData?.Length ?? 0;
        var deleteCount = deleteData?.Length ?? 0;
        try
        {
            var createMsg = GetSaveRequiredMessages(createData);
            if (!string.IsNullOrWhiteSpace(createMsg))
            {
                return new DealActivitySaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new DealActivitySaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MDealActivityEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MDealActivityEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MDealActivityEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MDealActivityEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new DealActivitySaveRangeDtoResponse()
            {
                IsSuccess = true,
                TotalCreated = createCount,
                TotalUpdated = updateCount,
                TotalDeleted = deleteCount,
                CreatedData = resultCreateDtos,
                UpdatedData = resultUpdateDtos,
                DeletedData = resultDeleteDtos,
                Message = sb.ToString(),
            }.GetResponse(functionName);
        }
        catch (Exception ex)
        {
            return new DealActivitySaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<DealActivitySaveRangeDtoResponse> SaveRangeAsync(DealActivitySaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MDealActivityEntity>?>(null));
    }

    public async Task<DealActivitySaveRangeDtoResponse> SaveRangeTransactionAsync(DealActivitySaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MDealActivityEntity>?>(null));
    }
}

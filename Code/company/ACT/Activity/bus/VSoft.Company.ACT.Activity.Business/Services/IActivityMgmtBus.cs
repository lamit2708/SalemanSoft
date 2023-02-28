using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.ACT.Activity.Business.Dto.Request;
using VSoft.Company.ACT.Activity.Business.Dto.Response;

namespace VSoft.Company.ACT.Activity.Business.Services;

public interface IActivityMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByLong request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByLong request);

    ActivityFindDtoResponse Find(MDtoRequestFindByLong request);

    Task<ActivityFindDtoResponse> FindAsync(MDtoRequestFindByLong request);

    ActivityFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request);

    Task<ActivityFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request);

    ActivityInsertDtoResponse Create(ActivityInsertDtoRequest request);

    Task<ActivityInsertDtoResponse> CreateAsync(ActivityInsertDtoRequest request);

    ActivityInsertRangeDtoResponse CreateRange(ActivityInsertRangeDtoRequest request);

    Task<ActivityInsertRangeDtoResponse> CreateRangeAsync(ActivityInsertRangeDtoRequest request);

    ActivityUpdateDtoResponse Update(ActivityUpdateDtoRequest request);

    Task<ActivityUpdateDtoResponse> UpdateAsync(ActivityUpdateDtoRequest request);

    ActivityUpdateRangeDtoResponse UpdateRange(ActivityUpdateRangeDtoRequest request);

    Task<ActivityUpdateRangeDtoResponse> UpdateRangeAsync(ActivityUpdateRangeDtoRequest request);

    ActivityDeleteDtoResponse Delete(ActivityDeleteDtoRequest request);

    Task<ActivityDeleteDtoResponse> DeleteAsync(ActivityDeleteDtoRequest request);

    ActivityDeleteRangeDtoResponse DeleteRange(ActivityDeleteRangeDtoRequest request);

    Task<ActivityDeleteRangeDtoResponse> DeleteRangeAsync(ActivityDeleteRangeDtoRequest request);

    Task<ActivitySaveRangeDtoResponse> SaveRangeAsync(ActivitySaveRangeDtoRequest request);

    Task<ActivitySaveRangeDtoResponse> SaveRangeTransactionAsync(ActivitySaveRangeDtoRequest request);
}

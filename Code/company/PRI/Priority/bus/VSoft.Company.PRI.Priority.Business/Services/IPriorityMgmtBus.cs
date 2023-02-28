﻿using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.PRI.Priority.Business.Dto.Request;
using VSoft.Company.PRI.Priority.Business.Dto.Response;

namespace VSoft.Company.PRI.Priority.Business.Services;

public interface IPriorityMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByLong request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByLong request);

    PriorityFindDtoResponse Find(MDtoRequestFindByLong request);

    Task<PriorityFindDtoResponse> FindAsync(MDtoRequestFindByLong request);

    PriorityFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request);

    Task<PriorityFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request);

    PriorityInsertDtoResponse Create(PriorityInsertDtoRequest request);

    Task<PriorityInsertDtoResponse> CreateAsync(PriorityInsertDtoRequest request);

    PriorityInsertRangeDtoResponse CreateRange(PriorityInsertRangeDtoRequest request);

    Task<PriorityInsertRangeDtoResponse> CreateRangeAsync(PriorityInsertRangeDtoRequest request);

    PriorityUpdateDtoResponse Update(PriorityUpdateDtoRequest request);

    Task<PriorityUpdateDtoResponse> UpdateAsync(PriorityUpdateDtoRequest request);

    PriorityUpdateRangeDtoResponse UpdateRange(PriorityUpdateRangeDtoRequest request);

    Task<PriorityUpdateRangeDtoResponse> UpdateRangeAsync(PriorityUpdateRangeDtoRequest request);

    PriorityDeleteDtoResponse Delete(PriorityDeleteDtoRequest request);

    Task<PriorityDeleteDtoResponse> DeleteAsync(PriorityDeleteDtoRequest request);

    PriorityDeleteRangeDtoResponse DeleteRange(PriorityDeleteRangeDtoRequest request);

    Task<PriorityDeleteRangeDtoResponse> DeleteRangeAsync(PriorityDeleteRangeDtoRequest request);

    Task<PrioritySaveRangeDtoResponse> SaveRangeAsync(PrioritySaveRangeDtoRequest request);

    Task<PrioritySaveRangeDtoResponse> SaveRangeTransactionAsync(PrioritySaveRangeDtoRequest request);
}

﻿using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.USR.User.Business.Dto.Request;
using VSoft.Company.USR.User.Business.Dto.Response;

namespace VSoft.Company.USR.User.Business.Services;

public interface IUserMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByLong request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByLong request);

    UserFindDtoResponse Find(MDtoRequestFindByLong request);

    Task<UserFindDtoResponse> FindAsync(MDtoRequestFindByLong request);

    UserFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request);

    Task<UserFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request);

    UserInsertDtoResponse Create(UserInsertDtoRequest request);

    Task<UserInsertDtoResponse> CreateAsync(UserInsertDtoRequest request);

    UserInsertRangeDtoResponse CreateRange(UserInsertRangeDtoRequest request);

    Task<UserInsertRangeDtoResponse> CreateRangeAsync(UserInsertRangeDtoRequest request);

    UserUpdateDtoResponse Update(UserUpdateDtoRequest request);

    Task<UserUpdateDtoResponse> UpdateAsync(UserUpdateDtoRequest request);

    UserUpdateRangeDtoResponse UpdateRange(UserUpdateRangeDtoRequest request);

    Task<UserUpdateRangeDtoResponse> UpdateRangeAsync(UserUpdateRangeDtoRequest request);

    UserDeleteDtoResponse Delete(UserDeleteDtoRequest request);

    Task<UserDeleteDtoResponse> DeleteAsync(UserDeleteDtoRequest request);

    UserDeleteRangeDtoResponse DeleteRange(UserDeleteRangeDtoRequest request);

    Task<UserDeleteRangeDtoResponse> DeleteRangeAsync(UserDeleteRangeDtoRequest request);

    Task<UserSaveRangeDtoResponse> SaveRangeAsync(UserSaveRangeDtoRequest request);

    Task<UserSaveRangeDtoResponse> SaveRangeTransactionAsync(UserSaveRangeDtoRequest request);
}
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.UCU.UserCustomer.Business.Dto.Request;
using VSoft.Company.UCU.UserCustomer.Business.Dto.Response;

namespace VSoft.Company.UCU.UserCustomer.Business.Services;

public interface IUserCustomerMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByLong request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByLong request);

    UserCustomerFindDtoResponse Find(MDtoRequestFindByLong request);

    Task<UserCustomerFindDtoResponse> FindAsync(MDtoRequestFindByLong request);

    UserCustomerFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request);

    Task<UserCustomerFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request);

    UserCustomerInsertDtoResponse Create(UserCustomerInsertDtoRequest request);

    Task<UserCustomerInsertDtoResponse> CreateAsync(UserCustomerInsertDtoRequest request);

    UserCustomerInsertRangeDtoResponse CreateRange(UserCustomerInsertRangeDtoRequest request);

    Task<UserCustomerInsertRangeDtoResponse> CreateRangeAsync(UserCustomerInsertRangeDtoRequest request);

    UserCustomerUpdateDtoResponse Update(UserCustomerUpdateDtoRequest request);

    Task<UserCustomerUpdateDtoResponse> UpdateAsync(UserCustomerUpdateDtoRequest request);

    UserCustomerUpdateRangeDtoResponse UpdateRange(UserCustomerUpdateRangeDtoRequest request);

    Task<UserCustomerUpdateRangeDtoResponse> UpdateRangeAsync(UserCustomerUpdateRangeDtoRequest request);

    UserCustomerDeleteDtoResponse Delete(UserCustomerDeleteDtoRequest request);

    Task<UserCustomerDeleteDtoResponse> DeleteAsync(UserCustomerDeleteDtoRequest request);

    UserCustomerDeleteRangeDtoResponse DeleteRange(UserCustomerDeleteRangeDtoRequest request);

    Task<UserCustomerDeleteRangeDtoResponse> DeleteRangeAsync(UserCustomerDeleteRangeDtoRequest request);

    Task<UserCustomerSaveRangeDtoResponse> SaveRangeAsync(UserCustomerSaveRangeDtoRequest request);

    Task<UserCustomerSaveRangeDtoResponse> SaveRangeTransactionAsync(UserCustomerSaveRangeDtoRequest request);
}

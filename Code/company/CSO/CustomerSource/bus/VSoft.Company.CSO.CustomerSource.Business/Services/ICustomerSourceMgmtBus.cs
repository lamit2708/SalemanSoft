using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.CSO.CustomerSource.Business.Dto.Request;
using VSoft.Company.CSO.CustomerSource.Business.Dto.Response;

namespace VSoft.Company.CSO.CustomerSource.Business.Services;

public interface ICustomerSourceMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByLong request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByLong request);

    CustomerSourceFindDtoResponse Find(MDtoRequestFindByLong request);

    Task<CustomerSourceFindDtoResponse> FindAsync(MDtoRequestFindByLong request);

    CustomerSourceFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request);

    Task<CustomerSourceFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request);

    CustomerSourceInsertDtoResponse Create(CustomerSourceInsertDtoRequest request);

    Task<CustomerSourceInsertDtoResponse> CreateAsync(CustomerSourceInsertDtoRequest request);

    CustomerSourceInsertRangeDtoResponse CreateRange(CustomerSourceInsertRangeDtoRequest request);

    Task<CustomerSourceInsertRangeDtoResponse> CreateRangeAsync(CustomerSourceInsertRangeDtoRequest request);

    CustomerSourceUpdateDtoResponse Update(CustomerSourceUpdateDtoRequest request);

    Task<CustomerSourceUpdateDtoResponse> UpdateAsync(CustomerSourceUpdateDtoRequest request);

    CustomerSourceUpdateRangeDtoResponse UpdateRange(CustomerSourceUpdateRangeDtoRequest request);

    Task<CustomerSourceUpdateRangeDtoResponse> UpdateRangeAsync(CustomerSourceUpdateRangeDtoRequest request);

    CustomerSourceDeleteDtoResponse Delete(CustomerSourceDeleteDtoRequest request);

    Task<CustomerSourceDeleteDtoResponse> DeleteAsync(CustomerSourceDeleteDtoRequest request);

    CustomerSourceDeleteRangeDtoResponse DeleteRange(CustomerSourceDeleteRangeDtoRequest request);

    Task<CustomerSourceDeleteRangeDtoResponse> DeleteRangeAsync(CustomerSourceDeleteRangeDtoRequest request);

    Task<CustomerSourceSaveRangeDtoResponse> SaveRangeAsync(CustomerSourceSaveRangeDtoRequest request);

    Task<CustomerSourceSaveRangeDtoResponse> SaveRangeTransactionAsync(CustomerSourceSaveRangeDtoRequest request);
}

using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.TIC.Ticket.Business.Dto.Request;
using VSoft.Company.TIC.Ticket.Business.Dto.Response;

namespace VSoft.Company.TIC.Ticket.Business.Services;

public interface ITicketMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByLong request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByLong request);

    TicketFindDtoResponse Find(MDtoRequestFindByLong request);

    Task<TicketFindDtoResponse> FindAsync(MDtoRequestFindByLong request);

    TicketFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request);

    Task<TicketFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request);

    TicketInsertDtoResponse Create(TicketInsertDtoRequest request);

    Task<TicketInsertDtoResponse> CreateAsync(TicketInsertDtoRequest request);

    TicketInsertRangeDtoResponse CreateRange(TicketInsertRangeDtoRequest request);

    Task<TicketInsertRangeDtoResponse> CreateRangeAsync(TicketInsertRangeDtoRequest request);

    TicketUpdateDtoResponse Update(TicketUpdateDtoRequest request);

    Task<TicketUpdateDtoResponse> UpdateAsync(TicketUpdateDtoRequest request);

    TicketUpdateRangeDtoResponse UpdateRange(TicketUpdateRangeDtoRequest request);

    Task<TicketUpdateRangeDtoResponse> UpdateRangeAsync(TicketUpdateRangeDtoRequest request);

    TicketDeleteDtoResponse Delete(TicketDeleteDtoRequest request);

    Task<TicketDeleteDtoResponse> DeleteAsync(TicketDeleteDtoRequest request);

    TicketDeleteRangeDtoResponse DeleteRange(TicketDeleteRangeDtoRequest request);

    Task<TicketDeleteRangeDtoResponse> DeleteRangeAsync(TicketDeleteRangeDtoRequest request);

    Task<TicketSaveRangeDtoResponse> SaveRangeAsync(TicketSaveRangeDtoRequest request);

    Task<TicketSaveRangeDtoResponse> SaveRangeTransactionAsync(TicketSaveRangeDtoRequest request);
}

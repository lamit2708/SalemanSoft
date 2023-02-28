using VSoft.Company.TIC.Ticket.Business.Dto.Data;
using VSoft.Company.TIC.Ticket.Data.Entity.Models;

namespace VSoft.Company.TIC.Ticket.Business.Dto.Extension.Methods;

public static class TicketDtoMethods
{
    public static MTicketEntity GetEntity(this TicketDto src, bool isForUpdate)
    {
        return new MTicketEntity()
        {
            Id = src.Id,
            Name = src.Name,
            Phone = src.Phone,
            Email = src.Email,
            Address = src.Address,
            Gender = src.Gender,
            PriorityId = src.PriorityId,
            TicketInfoId = src.TicketInfoId,
            IsBought = src.IsBought,
        };
    }
}

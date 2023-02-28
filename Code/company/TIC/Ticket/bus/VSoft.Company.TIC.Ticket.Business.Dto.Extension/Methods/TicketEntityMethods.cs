using VSoft.Company.TIC.Ticket.Business.Dto.Data;
using VSoft.Company.TIC.Ticket.Data.Entity.Models;

namespace VSoft.Company.TIC.Ticket.Business.entity.Extension.Methods;

public static class TicketEntityMethods
{
    public static TicketDto GetDto(this MTicketEntity src)
    {
        return new TicketDto()
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

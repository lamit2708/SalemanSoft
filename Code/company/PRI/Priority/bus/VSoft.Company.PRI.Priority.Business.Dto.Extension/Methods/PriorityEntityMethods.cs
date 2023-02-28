using VSoft.Company.PRI.Priority.Business.Dto.Data;
using VSoft.Company.PRI.Priority.Data.Entity.Models;

namespace VSoft.Company.PRI.Priority.Business.entity.Extension.Methods;

public static class PriorityEntityMethods
{
    public static PriorityDto GetDto(this MPriorityEntity src)
    {
        return new PriorityDto()
        {
            Id = src.Id,
            Name = src.Name,
            Phone = src.Phone,
            Email = src.Email,
            Address = src.Address,
            Gender = src.Gender,
            PriorityId = src.PriorityId,
            PriorityInfoId = src.PriorityInfoId,
            IsBought = src.IsBought,
        };
    }
}

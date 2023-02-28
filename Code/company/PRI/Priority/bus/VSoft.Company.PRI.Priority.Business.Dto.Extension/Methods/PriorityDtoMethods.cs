using VSoft.Company.PRI.Priority.Business.Dto.Data;
using VSoft.Company.PRI.Priority.Data.Entity.Models;

namespace VSoft.Company.PRI.Priority.Business.Dto.Extension.Methods;

public static class PriorityDtoMethods
{
    public static MPriorityEntity GetEntity(this PriorityDto src, bool isForUpdate)
    {
        return new MPriorityEntity()
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

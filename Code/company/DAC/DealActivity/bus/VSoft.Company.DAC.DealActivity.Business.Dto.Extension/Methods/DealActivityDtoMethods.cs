using VSoft.Company.DAC.DealActivity.Business.Dto.Data;
using VSoft.Company.DAC.DealActivity.Data.Entity.Models;

namespace VSoft.Company.DAC.DealActivity.Business.Dto.Extension.Methods;

public static class DealActivityDtoMethods
{
    public static MDealActivityEntity GetEntity(this DealActivityDto src, bool isForUpdate)
    {
        return new MDealActivityEntity()
        {
            Id = src.Id,
            Name = src.Name,
            Phone = src.Phone,
            Email = src.Email,
            Address = src.Address,
            Gender = src.Gender,
            PriorityId = src.PriorityId,
            DealActivityInfoId = src.DealActivityInfoId,
            IsBought = src.IsBought,
        };
    }
}

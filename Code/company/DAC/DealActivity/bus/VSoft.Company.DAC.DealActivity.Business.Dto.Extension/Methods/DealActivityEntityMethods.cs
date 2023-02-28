using VSoft.Company.DAC.DealActivity.Business.Dto.Data;
using VSoft.Company.DAC.DealActivity.Data.Entity.Models;

namespace VSoft.Company.DAC.DealActivity.Business.entity.Extension.Methods;

public static class DealActivityEntityMethods
{
    public static DealActivityDto GetDto(this MDealActivityEntity src)
    {
        return new DealActivityDto()
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

using VSoft.Company.DSH.DealStepHistory.Business.Dto.Data;
using VSoft.Company.DSH.DealStepHistory.Data.Entity.Models;

namespace VSoft.Company.DSH.DealStepHistory.Business.entity.Extension.Methods;

public static class DealStepHistoryEntityMethods
{
    public static DealStepHistoryDto GetDto(this MDealStepHistoryEntity src)
    {
        return new DealStepHistoryDto()
        {
            Id = src.Id,
            Name = src.Name,
            Phone = src.Phone,
            Email = src.Email,
            Address = src.Address,
            Gender = src.Gender,
            PriorityId = src.PriorityId,
            DealStepHistoryInfoId = src.DealStepHistoryInfoId,
            IsBought = src.IsBought,
        };
    }
}

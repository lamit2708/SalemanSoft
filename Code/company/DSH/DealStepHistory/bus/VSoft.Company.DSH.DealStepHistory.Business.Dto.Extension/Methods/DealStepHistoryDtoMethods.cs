using VSoft.Company.DSH.DealStepHistory.Business.Dto.Data;
using VSoft.Company.DSH.DealStepHistory.Data.Entity.Models;

namespace VSoft.Company.DSH.DealStepHistory.Business.Dto.Extension.Methods;

public static class DealStepHistoryDtoMethods
{
    public static MDealStepHistoryEntity GetEntity(this DealStepHistoryDto src, bool isForUpdate)
    {
        return new MDealStepHistoryEntity()
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

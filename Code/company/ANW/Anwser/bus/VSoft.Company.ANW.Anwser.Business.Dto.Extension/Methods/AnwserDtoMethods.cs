using VSoft.Company.ANW.Anwser.Business.Dto.Data;
using VSoft.Company.ANW.Anwser.Data.Entity.Models;

namespace VSoft.Company.ANW.Anwser.Business.Dto.Extension.Methods;

public static class AnwserDtoMethods
{
    public static MAnwserEntity GetEntity(this AnwserDto src, bool isForUpdate)
    {
        return new MAnwserEntity()
        {
            Id = src.Id,
            Name = src.Name,
            Phone = src.Phone,
            Email = src.Email,
            Address = src.Address,
            Gender = src.Gender,
            PriorityId = src.PriorityId,
            AnwserInfoId = src.AnwserInfoId,
            IsBought = src.IsBought,
        };
    }
}

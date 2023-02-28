using VSoft.Company.ANW.Anwser.Business.Dto.Data;
using VSoft.Company.ANW.Anwser.Data.Entity.Models;

namespace VSoft.Company.ANW.Anwser.Business.entity.Extension.Methods;

public static class AnwserEntityMethods
{
    public static AnwserDto GetDto(this MAnwserEntity src)
    {
        return new AnwserDto()
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

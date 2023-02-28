using VSoft.Company.CIN.CustomerInfo.Business.Dto.Data;
using VSoft.Company.CIN.CustomerInfo.Data.Entity.Models;

namespace VSoft.Company.CIN.CustomerInfo.Business.Dto.Extension.Methods;

public static class CustomerInfoDtoMethods
{
    public static MCustomerInfoEntity GetEntity(this CustomerInfoDto src, bool isForUpdate)
    {
        return new MCustomerInfoEntity()
        {
            Id = src.Id,
            Name = src.Name,
            Phone = src.Phone,
            Email = src.Email,
            Address = src.Address,
            Gender = src.Gender,
            PriorityId = src.PriorityId,
            CustomerInfoInfoId = src.CustomerInfoInfoId,
            IsBought = src.IsBought,
        };
    }
}

using VSoft.Company.CIN.CustomerInfo.Business.Dto.Data;
using VSoft.Company.CIN.CustomerInfo.Data.Entity.Models;

namespace VSoft.Company.CIN.CustomerInfo.Business.entity.Extension.Methods;

public static class CustomerInfoEntityMethods
{
    public static CustomerInfoDto GetDto(this MCustomerInfoEntity src)
    {
        return new CustomerInfoDto()
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

using VSoft.Company.UCU.UserCustomer.Business.Dto.Data;
using VSoft.Company.UCU.UserCustomer.Data.Entity.Models;

namespace VSoft.Company.UCU.UserCustomer.Business.entity.Extension.Methods;

public static class UserCustomerEntityMethods
{
    public static UserCustomerDto GetDto(this MUserCustomerEntity src)
    {
        return new UserCustomerDto()
        {
            Id = src.Id,
            Name = src.Name,
            Phone = src.Phone,
            Email = src.Email,
            Address = src.Address,
            Gender = src.Gender,
            PriorityId = src.PriorityId,
            UserCustomerInfoId = src.UserCustomerInfoId,
            IsBought = src.IsBought,
        };
    }
}

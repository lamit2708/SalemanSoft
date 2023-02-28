using VSoft.Company.UCU.UserCustomer.Business.Dto.Data;
using VSoft.Company.UCU.UserCustomer.Data.Entity.Models;

namespace VSoft.Company.UCU.UserCustomer.Business.Dto.Extension.Methods;

public static class UserCustomerDtoMethods
{
    public static MUserCustomerEntity GetEntity(this UserCustomerDto src, bool isForUpdate)
    {
        return new MUserCustomerEntity()
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

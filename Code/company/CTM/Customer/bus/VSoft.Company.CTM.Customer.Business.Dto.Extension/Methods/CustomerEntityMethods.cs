using VSoft.Company.CTM.Customer.Business.Dto.Data;
using VSoft.Company.CTM.Customer.Data.Entity.Models;

namespace VSoft.Company.CTM.Customer.Business.entity.Extension.Methods;

public static class CustomerEntityMethods
{
    public static CustomerDto GetDto(this MCustomerEntity src)
    {
        return new CustomerDto()
        {
            Id = src.Id,
            FullName = src.FullName,
            IsDeleted = src.IsDeleted,
            CreatedDate = src.CreatedDate,
            UpdatedDate = src.UpdatedDate,
        };
    }
}

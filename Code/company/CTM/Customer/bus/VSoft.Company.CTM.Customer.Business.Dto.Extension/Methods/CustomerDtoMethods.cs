using VSoft.Company.CTM.Customer.Business.Dto.Data;
using VSoft.Company.CTM.Customer.Data.Entity.Models;

namespace VSoft.Company.CTM.Customer.Business.Dto.Extension.Methods;

public static class CustomerDtoMethods
{
    public static MCustomerEntity GetEntity(this CustomerDto src, bool isForUpdate)
    {
        return new MCustomerEntity()
        {
            Id = src.Id,
            FullName = src.FullName,
            IsDeleted = src.IsDeleted,          
            CreatedDate = !isForUpdate ? DateTime.Now : src.CreatedDate,
            UpdatedDate = isForUpdate ? DateTime.Now : src.UpdatedDate,
           
        };
    }
}

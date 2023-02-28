using VSoft.Company.URO.UserRole.Business.Dto.Data;
using VSoft.Company.URO.UserRole.Data.Entity.Models;

namespace VSoft.Company.URO.UserRole.Business.entity.Extension.Methods;

public static class UserRoleEntityMethods
{
    public static UserRoleDto GetDto(this MUserRoleEntity src)
    {
        return new UserRoleDto()
        {
            Id = src.Id,
            Name = src.Name,
            Phone = src.Phone,
            Email = src.Email,
            Address = src.Address,
            Gender = src.Gender,
            PriorityId = src.PriorityId,
            UserRoleInfoId = src.UserRoleInfoId,
            IsBought = src.IsBought,
        };
    }
}

using VSoft.Company.ROL.Role.Business.Dto.Data;
using VSoft.Company.ROL.Role.Data.Entity.Models;

namespace VSoft.Company.ROL.Role.Business.entity.Extension.Methods;

public static class RoleEntityMethods
{
    public static RoleDto GetDto(this MRoleEntity src)
    {
        return new RoleDto()
        {
            Id = src.Id,
            Name = src.Name,
            Phone = src.Phone,
            Email = src.Email,
            Address = src.Address,
            Gender = src.Gender,
            PriorityId = src.PriorityId,
            RoleInfoId = src.RoleInfoId,
            IsBought = src.IsBought,
        };
    }
}

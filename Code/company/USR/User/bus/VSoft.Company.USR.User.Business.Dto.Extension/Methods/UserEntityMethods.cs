﻿using VSoft.Company.USR.User.Business.Dto.Data;
using VSoft.Company.USR.User.Data.Entity.Models;

namespace VSoft.Company.USR.User.Business.entity.Extension.Methods;

public static class UserEntityMethods
{
    public static UserDto GetDto(this MUserEntity src)
    {
        return new UserDto()
        {
            Id = src.Id,
            Name = src.Name,
            Phone = src.Phone,
            Email = src.Email,
            Username = src.Username,
            Password = src.Password,
            TeamId = src.TeamId,

        };
    }
}

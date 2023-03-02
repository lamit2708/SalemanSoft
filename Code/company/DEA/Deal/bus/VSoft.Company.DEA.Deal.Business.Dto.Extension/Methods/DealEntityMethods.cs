﻿using VSoft.Company.DEA.Deal.Business.Dto.Data;
using VSoft.Company.DEA.Deal.Data.Entity.Models;

namespace VSoft.Company.DEA.Deal.Business.entity.Extension.Methods;

public static class DealEntityMethods
{
    public static DealDto GetDto(this MDealEntity src)
    {
        return new DealDto()
        {
            Id = src.Id,
            Name = src.Name,
            CreatedDate = src.CreatedDate,
            DealId = src.DealId,
            DealStepId = src.DealStepId,
            UserId = src.UserId,
            OrderId = src.OrderId,
            Description = src.Description,
        };
    }
}
